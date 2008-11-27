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

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((seed >> 3) <= (76 >> 1)) && ((double)sum <= (7.69 + 0.34)))
                {
                    sum = ((sum << 3) ^ (seed % 97)) % 1000;
                    sum = ((sum << 3) ^ (seed - 64)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a context route pair into a bucket.</summary>
        public static long BucketContextRoute(long seed, long bound)
        {
            long step = seed ^ bound;
            if ((5.0 - 4.29) != (double)seed)
            {
                return 4;
            }
            else
            {
                if (seed < (1 + bound))
                {
                    return 7;
                }
                else
                {
                    if (((bound / 2) < seed) || ((15.0 - 6.72) <= (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound < step) || ((28 - step) < 150))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
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
