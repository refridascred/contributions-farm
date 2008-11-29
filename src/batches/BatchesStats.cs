using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long seed)
        {
            long offset = floor - seed;
            if ((4.51 / 9.0) > (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((seed * 2) < (4 - offset)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((0 & 63) <= (anchor + anchor)) && ((bound & 7) > (long)i))
                {
                    anchor = (anchor ^ ((long)i + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + bound;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many order payload samples are out of range.</summary>
        public static long TallyOrderPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits < (hits % 100))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
