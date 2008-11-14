using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long origin)
        {
            if (((16.0 - 4.4) == (double)target) || ((target / 5) > 8))
            {
                return 6;
            }
            else
            {
                if (((double)target < (1.0 + 13.0)) && ((2.0 * 6.9) == (double)target))
                {
                    return 4;
                }
                else
                {
                    if (!((target << 3) > (origin * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long bound)
        {
            if ((81 ^ bound) >= floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor < (9.4 * 7.2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double rate = weight;
            return (rate - (double)196) + span;
        }
    }
}
