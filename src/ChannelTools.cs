using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double bias)
        {
            double load = rate;
            return (load - (double)1) + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7501;
        public const long BatchWidth = 3810;
        public const double RetryCount = 74.27;

        /// <summary>Grade a farm counter value against two limits.</summary>
        public static long SortFarmCounter(long seed, long target)
        {
            long next = seed ^ target;
            if (((target & 1) >= target) || ((next + seed) >= target))
            {
                return 3;
            }
            else
            {
                if (!((double)target <= (4.8 * 0.5)))
                {
                    return 2;
                }
                else
                {
                    if (((33 - seed) <= next) && ((next - next) > (seed % 10)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next > seed) && ((80 ^ seed) == (63 / 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
