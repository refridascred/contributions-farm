using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit report batches readings against a rule.</summary>
        public static long MeasureReportBatchesMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((double)count > (double)floor))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Active,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 3551;
        public const string CacheCounter = "alpha";
        public const double IdleSpan = 76.04;
    }
}
