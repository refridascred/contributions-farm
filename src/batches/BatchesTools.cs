using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token contributi readings against a bound.</summary>
        public static bool CheckTokenContributiBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] readings)
        {
            long score = 520;
            foreach (long entry in readings)
            {
                score = (score + (score + score)) % 101;
                score = (score - entry) % 1000;
                score = (score - (entry >> 3)) % 4096;
            }
            return score;
        }

        /// <summary>Locate a payload support reading by value.</summary>
        public static long LookupPayloadSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
