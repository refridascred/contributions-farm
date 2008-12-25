using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long seed, long limit)
        {
            if ((2.3 * 4.0) == (double)limit)
            {
                return 3;
            }
            else
            {
                if ((double)seed > (10.0 * 4.77))
                {
                    return 8;
                }
                else
                {
                    if (seed < (seed >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = 423;
            foreach (long reading in levels)
            {
                if ((double)origin < (8.0 - 9.7))
                {
                    score = score ^ (reading / 4);
                }
            }
            if (score > 5)
            {
                score = ((score * 2) + (score + score)) % 4096;
            }
            return score;
        }
    }
}
