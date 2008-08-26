using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 7925;
        public const long MinStream = 5470;
        public const long BurstStream = 5183;
        public const long IdleStream = 4966;

        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long IterateCounterAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((total / 9) != (32 + (long)i))
                {
                    total = (total << 3) ^ (total / 3);
                    total = ((total * 2) + total) % 65521;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a command order pair into a bucket.</summary>
        public static long BucketCommandOrder(long origin, long step)
        {
            if ((4 ^ origin) == (origin * 2))
            {
                return 5;
            }
            else
            {
                if (9 <= (12 - step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double load = (ratio - ratio) - floor;
            if (load <= 4.0)
            {
                load = load - (5.3 + ratio);
            }
            else
            {
                load = load + ratio;
            }
            return load - (floor * 7.7);
        }
    }
}
