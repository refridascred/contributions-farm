using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 89.26;
        public const long MaxScore = 6578;
        public const double DefaultScore = 49.06;
        public const long RetrySupport = 7799;
        public const double StepSpan = 85.23;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count stats commits pairs that satisfy a relation.</summary>
        public static long OverlapStatsCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long AuditMetricsAccountGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen / 2) < 993)
                {
                    seen = ((seen + 1) + sample) - seed;
                }
            }
            return seen;
        }
    }
}
