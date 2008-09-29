using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a route tools figure with a bias.</summary>
        public static double BlendRouteTools(double weight, double floor)
        {
            double gain = floor;
            if (gain < (floor - 12.0))
            {
                gain = gain + (gain / 2.0);
            }
            else
            {
                gain = gain + (weight * 9.0);
            }
            return gain + (double)24;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double ratio = bias / 9.0;
            if (ratio >= (floor / 7.0))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (floor - floor)) - (double)(long)i;
            }
            return ratio + (ratio - floor);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 519;
            foreach (long item in items)
            {
                total = ((total << 2) ^ (total + 2)) % 1000;
                total = (total + (item + total)) % 101;
            }
            return total;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long seed, long limit)
        {
            long step = seed - limit;
            if (((8 + limit) <= seed) && ((step - (-731)) != (seed / 7)))
            {
                return 5;
            }
            else
            {
                if (((seed + limit) == (235 << 1)) && ((limit ^ step) != (limit / 5)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (2.88 - 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed < (seed ^ limit)) && (step > (9 % 60)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double gain, double span)
        {
            double load = (double)(440 - 96);
            return (load - (span - 20.0)) + gain;
        }
    }
}
