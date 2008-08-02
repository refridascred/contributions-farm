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

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 28.32;
        public const long RetryTimeout = 4421;
        public const double BatchCache = 41.0;
        public const double BaseCache = 65.88;

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

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target + target) < (target * 5))
                {
                    sum = (sum << 2) ^ ((long)i % 10);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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
