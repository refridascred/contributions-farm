using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings)
        {
            long sum = 785;
            foreach (long datum in readings)
            {
                sum = ((sum - sum) % 101) ^ datum;
            }
            if (sum < 2)
            {
                sum = ((sum * 2) + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data, long seed)
        {
            long anchor = 71;
            foreach (long item in data)
            {
                if ((anchor >= (75 - item)) || ((double)seed < 7.18))
                {
                    anchor = (anchor << 3) ^ (seed / 6);
                }
                else
                {
                    anchor = (anchor << 3) ^ 2;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + (seed << 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Pending,
            Done,
        }
    }
}
