using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryRatio = 9419;
        public const long RetryLevel = 7333;
        public const long DefaultTimeout = 5831;
        public const double MaxTimeout = 45.79;
        public const double BaseContributi = 64.83;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
