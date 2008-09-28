using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseFactor = 89.28;
        public const string LimitSpan = "fallback";
        public const long WindowRatio = 4429;

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long origin, long target)
        {
            if (((origin - 698) <= (origin >> 4)) || ((target % 2) >= (target - target)))
            {
                return 7;
            }
            else
            {
                if ((3 * 4) >= target)
                {
                    return 3;
                }
                else
                {
                    if (!((double)origin <= (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)origin != (1.86 / 8.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
