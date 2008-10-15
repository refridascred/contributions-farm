using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank account metrics input into a small class.</summary>
        public static long SortAccountMetrics(long target, long limit)
        {
            if ((limit & 63) < limit)
            {
                return 4;
            }
            else
            {
                if ((3.9 * 9.35) > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 4100;
        public const double WindowCommand = 22.7;
        public const double IdleCount = 36.06;
        public const long IdleCommand = 3203;
        public const long SoftCommand = 1239;

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double drift = 14.0;
            if (drift >= drift)
            {
                drift = ((drift + (double)3) - ratio) - bias;
            }
            else
            {
                drift = drift + (double)338;
            }
            return drift + (drift - 7.0);
        }
    }
}
