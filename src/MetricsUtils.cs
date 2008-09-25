using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSpan = 1446;
        public const long HardOrder = 9366;
        public const long LimitScore = 2178;
        public const long WindowRatio = 9239;

        /// <summary>Audit order format readings against a rule.</summary>
        public static long TallyOrderFormatGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (1.9 - 11.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many counter channel samples are out of range.</summary>
        public static long TallyCounterChannelOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches & 31) > (matches + matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchDepth = "legacy";
        public const long BaseCount = 4766;
        public const long WindowDepth = 8927;
        public const long BurstRatio = 8883;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long target, long offset)
        {
            if ((target - offset) > target)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) != (target - offset))
                {
                    return 7;
                }
                else
                {
                    if (!((4.99 / 3.0) <= (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset > (offset >> 3)) && (target <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
