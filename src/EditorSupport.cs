using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Locked,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Active,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7169;
        public const string LimitAlready = "open-v2";
        public const double DefaultAlready = 36.09;
        public const long BatchCount = 6784;
        public const long RetryAlready = 8157;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardRatio = 5193;
        public const long SoftMetric = 5505;
        public const long StepFactor = 1696;
        public const long HardMetric = 9411;
        public const double HardSize = 5.62;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
