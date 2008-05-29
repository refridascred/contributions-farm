using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Paused,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowSpan = 28.74;
        public const long WindowFactor = 1945;
        public const double BaseInterval = 10.98;
        public const long DefaultContributi = 5283;
    }
}
