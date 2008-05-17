using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank cluster already input into a small class.</summary>
        public static long BucketClusterAlready(long origin, long step)
        {
            if ((75 * 3) >= (step + origin))
            {
                return 7;
            }
            else
            {
                if ((1.7 * 5.97) > (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((85 + origin) > (origin + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftWidth = 78.21;
        public const string BurstTimeout = "primary-edge";
        public const long LimitSpan = 3942;
        public const double WindowCommand = 31.36;
        public const string RetryInterval = "standard-1";

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double bias, double offset)
        {
            double bias2 = (double)848;
            if (bias2 < (double)23)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (offset - bias)) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
