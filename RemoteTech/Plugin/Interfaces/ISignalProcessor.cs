﻿using System;
using UnityEngine;

namespace RemoteTech {
    public interface ISignalProcessor {
        bool Powered { get; }
        String Name { get; }
        Guid Guid { get; }
        Vector3 Position { get; }
        CelestialBody Body { get; }
        Vessel Vessel { get; }
    }
}