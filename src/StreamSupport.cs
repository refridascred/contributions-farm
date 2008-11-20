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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long seed)
        {
            if (877 >= (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (2.0 + 7.9))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
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
