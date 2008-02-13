using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long floor)
        {
            long slot = seed - floor;
            if ((slot & 1) <= 83)
            {
                return 3;
            }
            else
            {
                if ((slot ^ slot) < floor)
                {
                    return 8;
                }
                else
                {
                    if ((double)slot == (0.6 / 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 2) ^ (carry / 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((2 & 7) > (limit ^ limit))
            {
                return 7;
            }
            else
            {
                if ((origin + 570) != (origin / 9))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (12.0 * 9.55))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Pending,
            Active,
        }
    }
}
