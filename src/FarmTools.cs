using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                if (!((8.8 + 7.34) >= (double)(long)i))
                {
                    total = (total + bound) % 4096;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (((total * 2) + (bound + total)) % 255) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long origin, long target)
        {
            long next = origin - target;
            if ((9.0 - 6.37) <= (double)next)
            {
                return 1;
            }
            else
            {
                if ((origin << 3) <= (95 << 3))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftTimeout = 7435;
        public const long BurstScore = 1097;
        public const double SoftScore = 18.03;
        public const string DefaultDepth = "standard-1";
        public const long IdleChecks = 2691;
    }
}
