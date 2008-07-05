using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            Locked,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 1439;
        public const long CacheFactor = 805;
        public const double MaxSchema = 79.09;
        public const long MinSchema = 9305;
        public const long HardSchema = 6707;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
