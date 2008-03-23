using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultSize = 7639;
        public const long DefaultToken = 43;
        public const long BurstToken = 1383;
        public const long BatchToken = 5149;
        public const long MinToken = 972;

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double ratio = scale * 4.0;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (scale + span)) + (double)(long)i;
            }
            return ratio - (ratio / 9.0);
        }

        /// <summary>Classify a route batches pair into a bucket.</summary>
        public static long BucketRouteBatches(long step, long seed)
        {
            if (((double)step <= (double)seed) && ((double)seed != (7.7 + 3.3)))
            {
                return 7;
            }
            else
            {
                if ((6 < (seed + 689)) && ((double)seed <= (2.43 - 5.73)))
                {
                    return 0;
                }
                else
                {
                    if (!((seed / 2) > step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >> 2) <= (seed - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
