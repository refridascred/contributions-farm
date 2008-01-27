using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score * 2) + (score * 4)) - (long)i2;
                }
                score = ((score << 3) ^ (score + (long)i)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
