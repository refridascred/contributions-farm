using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 5824;
        public const long BatchNotes = 1439;
        public const long BurstNotes = 1400;
        public const string DefaultNotes = "cached";
        public const string LimitFactor = "local";
    }
}
