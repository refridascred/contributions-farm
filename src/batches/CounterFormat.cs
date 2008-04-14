using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the route tools series from a seed.</summary>
        public static long DeriveRouteTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long seed)
        {
            long sum = 5;
            foreach (long value in series)
            {
                sum = ((sum << 3) ^ sum) - seed;
                if ((value >= (sum << 2)) && (((long)series.Length - sum) > (89 * 4)))
                {
                    break;
                }
            }
            if (sum < 674)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long target)
        {
            if (((floor & 7) < (floor ^ floor)) && (floor < (floor ^ (-8))))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (20.0 - 10.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
