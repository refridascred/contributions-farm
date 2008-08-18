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

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Size { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
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
