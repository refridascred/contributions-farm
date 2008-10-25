using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "primary-v2";
        public const long WindowMetrics = 4746;
        public const string HardRatio = "fallback";
        public const double DefaultWidth = 14.42;
        public const long BatchMetrics = 5712;

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] values, long bound)
        {
            long mark = -80;
            foreach (long sample in values)
            {
                mark = (mark ^ (98 ^ sample)) - bound;
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((target + reading) <= target)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
