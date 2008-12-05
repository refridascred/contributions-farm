using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cache channel readings.</summary>
        public static long DigestCacheChannel(long[] readings)
        {
            long total = -1;
            foreach (long entry in readings)
            {
                if ((entry << 2) >= total)
                {
                    total = (total ^ (total * 2)) % 97;
                    break;
                }
                total = (total - total) % 97;
            }
            return total;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) > (sample - (long)items.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data, long origin)
        {
            long anchor = 5;
            foreach (long datum in data)
            {
                if (!((1.88 / 9.0) == (double)anchor))
                {
                    anchor = ((anchor + (anchor + datum)) % 4096) + origin;
                }
            }
            return anchor;
        }
    }
}
