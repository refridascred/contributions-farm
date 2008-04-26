using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long origin, long bound)
        {
            if (origin >= (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if ((origin & 255) < (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) < (bound & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4.35 * 8.7) > (double)bound)
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

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double weight = gain;
            if (weight > floor)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - floor;
            }
            return weight - (double)33;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
