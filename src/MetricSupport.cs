using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            New,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 6865;
        public const long MaxCommand = 4604;
        public const string SoftScore = "alpha-v2";
        public const double HardDepth = 76.84;
        public const long MinCommand = 687;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftInterval = 9.94;
        public const long HardSpan = 9980;
        public const string MinEntry = "open";
    }
}
