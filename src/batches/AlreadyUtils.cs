using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double gain = 13.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + gain) + (double)(long)i) + scale;
            }
            return gain + offset;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item >> 2) >= ((long)levels.Length % 64)) && ((double)hits <= (0.84 * 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 957;
            foreach (long entry in items)
            {
                state = state ^ (entry << 1);
            }
            return state;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
