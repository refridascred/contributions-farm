using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long floor, long step)
        {
            if (((-68) ^ 655) >= (step % 8))
            {
                return 2;
            }
            else
            {
                if ((931 / 5) > (floor / 6))
                {
                    return 4;
                }
                else
                {
                    if (floor <= (floor + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 9404;
        public const long RetrySpan = 7381;
        public const string RetryBatch = "standard-1";
        public const long HardSpan = 2029;

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long step)
        {
            long lane = offset - step;
            if ((step + lane) == (offset + lane))
            {
                return 8;
            }
            else
            {
                if (offset < (step << 1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
