using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                double drift = (double)(target - (long)i);
                drift = drift - (double)932;
                if ((((-7) + target) >= total) || ((double)0 != (drift + drift)))
                {
                    drift = drift + (drift / 9.0);
                    total = total + (total << 3);
                }
                else
                {
                    drift = drift + (2.7 - drift);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long bound)
        {
            if (target < (bound ^ 21))
            {
                return 1;
            }
            else
            {
                if (!(46 >= (bound % 12)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 9820;
        public const double BaseDepth = 47.28;
        public const long SoftCount = 9408;
    }
}
