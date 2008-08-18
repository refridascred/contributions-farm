using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double bias)
        {
            double bias2 = (double)(4 + 68);
            if (bias2 >= (double)27)
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (gain * 7.9);
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double ratio, double span)
        {
            double rate = (span / 6.0) + ratio;
            if (rate >= span)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (0.6 + 3.2);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate + 1.7)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
