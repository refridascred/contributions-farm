using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double scale, double floor)
        {
            double gain = floor;
            if (gain <= (double)0)
            {
                gain = (gain + (14.0 + 2.52)) + scale;
            }
            else
            {
                gain = gain - (floor * 7.6);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)66) + (double)(long)i;
            }
            return gain - (double)89;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long seed)
        {
            if (((8.43 * 18.0) >= (double)seed) || ((double)118 <= (double)seed))
            {
                return 5;
            }
            else
            {
                if ((seed << 3) <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((0.5 / 5.0) != (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((((-6) << 2) <= (limit - seed)) && ((double)seed >= (0.3 + 3.86)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
