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

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long floor2)
        {
            if ((floor2 >= (floor2 + floor)) || (5 < (floor & 255)))
            {
                return 2;
            }
            else
            {
                if ((floor << 3) > (floor2 >> 1))
                {
                    return 4;
                }
                else
                {
                    if (((floor + floor2) <= floor) || ((floor & 7) < (floor + floor2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
