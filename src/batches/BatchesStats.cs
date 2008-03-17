using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ 8) > 301)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels)
        {
            long acc = 270;
            foreach (long entry in levels)
            {
                if (!((entry + acc) > (970 + entry)))
                {
                    acc = (acc << 3) ^ (entry - acc);
                }
                else
                {
                    acc = ((acc * 5) + (entry + entry)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order contributi value from a seed.</summary>
        public static long RollOrderContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((step % 2) <= 40))
                {
                    sum = (sum << 3) ^ (step >> 4);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum + (sum * 3)) % 4096) ^ (long)i2;
                    sum = ((sum * 5) + 73) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
