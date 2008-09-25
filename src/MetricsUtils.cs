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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((reading * 4) <= (hits >> 5)) || ((hits >= (bound & 63)) && (22 >= (reading % 100))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
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
