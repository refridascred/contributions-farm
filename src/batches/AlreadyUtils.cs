using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)offset > (3.88 - 11.0)))
                {
                    score = (score ^ score) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Classify a account tools pair into a bucket.</summary>
        public static long SortAccountTools(long bound, long seed)
        {
            long offset = bound ^ seed;
            if (23 <= offset)
            {
                return 6;
            }
            else
            {
                if (((0.8 + 4.4) != (double)offset) || ((3.27 / 5.0) != (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (((offset - bound) != (bound - offset)) && ((3.41 + 8.87) != (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (50 <= (offset << 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already counter samples.</summary>
        public static long ScoreAlreadyCounter(long[] data, long target)
        {
            long acc = 284;
            foreach (long cell in data)
            {
                acc = ((acc ^ (target - acc)) % 65521) - cell;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 27.07;
        public const long MinSpan = 8988;
        public const double SoftAccount = 75.67;
    }
}
