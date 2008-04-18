using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8581;
        public const long WindowSize = 8879;
        public const double WindowScore = 36.35;
        public const double DefaultLevel = 94.18;
        public const string IdleCache = "alpha";

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstInterval = 2964;
        public const long MaxQueue = 2849;
        public const double WindowRatio = 27.27;
        public const long BatchQueue = 7526;
        public const long MinTimeout = 2283;
    }
}
