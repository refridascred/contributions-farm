using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Stale,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double load = 6.0;
            if (load > (double)6)
            {
                load = ((load + 4.22) + gain) - bias;
            }
            return load + (double)969;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long seed)
        {
            if ((200 >> 4) <= target)
            {
                return 2;
            }
            else
            {
                if (((target - target) >= (seed << 2)) && ((9.0 + 9.07) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank command window input into a small class.</summary>
        public static long RankCommandWindow(long bound, long floor)
        {
            long slot = bound + floor;
            if (!(slot <= bound))
            {
                return 3;
            }
            else
            {
                if (((floor + bound) <= (floor >> 4)) || ((bound - bound) < ((-35) - bound)))
                {
                    return 1;
                }
                else
                {
                    if ((floor + 6) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((slot / 2) <= (slot + 94))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
