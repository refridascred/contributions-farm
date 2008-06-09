using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Locked,
            New,
            Synced,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 3450;
        public const long BurstWindow = 9635;
        public const long CacheInterval = 7490;
        public const long DefaultInterval = 4825;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Pending,
            Active,
            Retry,
        }
    }
}
