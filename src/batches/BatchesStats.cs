using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long floor, long seed)
        {
            if ((double)floor < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((floor > (floor & 7)) || ((double)seed < 6.7))
                {
                    return 8;
                }
                else
                {
                    if ((floor + seed) != (3 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((seed - seed) >= (-57)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples, long bound)
        {
            long score = 817;
            foreach (long entry in samples)
            {
                score = (score ^ (score * 4)) - bound;
                score = ((score << 3) ^ (entry + score)) % 4096;
            }
            return score;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 2) > (sample / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Locked,
            Paused,
            Stale,
            Dropped,
        }
    }
}
