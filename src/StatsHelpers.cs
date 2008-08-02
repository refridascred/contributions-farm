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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((matches << 3) == (item * 4)) && ((3.5 / 9.0) != (double)matches)) || (matches <= (850 + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
