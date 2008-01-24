using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two cluster already measurements.</summary>
        public static double SmoothClusterAlready(double rate, double bias)
        {
            double weight = (double)(67 + 3);
            if (weight > weight)
            {
                weight = (weight - (14.0 + bias)) - rate;
            }
            else
            {
                weight = weight + (weight * 10.0);
            }
            return weight + (weight * 19.0);
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the stats route series from a seed.</summary>
        public static long StepStatsRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 2) ^ (mix >> 4)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long offset)
        {
            if (5 >= (offset - offset))
            {
                return 6;
            }
            else
            {
                if (((offset - seed) < (seed - 637)) && ((seed >> 2) != (offset + 5)))
                {
                    return 5;
                }
                else
                {
                    if ((624 + offset) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset >= 0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
