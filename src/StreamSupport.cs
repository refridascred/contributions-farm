using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long bound)
        {
            if ((bound & 7) >= (offset ^ bound))
            {
                return 4;
            }
            else
            {
                if (bound <= (3 - 0))
                {
                    return 6;
                }
                else
                {
                    if ((bound / 4) > (offset << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double floor)
        {
            double gain = ratio;
            if (gain >= (floor * 8.6))
            {
                gain = gain + (floor * 12.0);
            }
            else
            {
                gain = gain + floor;
            }
            return gain - (gain * 9.9);
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long step)
        {
            long lane = seed ^ step;
            if ((step << 1) != (seed / 4))
            {
                return 3;
            }
            else
            {
                if ((lane >> 2) >= (lane >> 3))
                {
                    return 4;
                }
                else
                {
                    if (1.7 < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + 323) <= (seed % 7))
                        {
                            return 8;
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
