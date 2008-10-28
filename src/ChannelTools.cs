using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a queue counter reading.</summary>
        public static double ProjectQueueCounter(double scale, double bias)
        {
            double drift = scale;
            return drift - (drift - bias);
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long target)
        {
            long diff = seed ^ target;
            if (((double)19 == (double)target) || (seed > (seed * 3)))
            {
                return 6;
            }
            else
            {
                if (((2.9 - 8.0) > (double)target) || ((double)target != (double)37))
                {
                    return 1;
                }
                else
                {
                    if (!((seed + diff) != (88 + seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)diff > (12.0 * 0.93)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats session entries that pass the check.</summary>
        public static long CountStatsSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 255) != (6 * 5))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
