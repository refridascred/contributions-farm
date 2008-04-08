using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if ((acc < 2) && ((long)i < target))
                {
                    acc = ((acc * 3) + target) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long limit)
        {
            if ((double)step > (double)limit)
            {
                return 7;
            }
            else
            {
                if ((step >> 4) > (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit == (double)step) && ((212 - limit) != (limit & 255)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step != (double)limit) && (step > (step + limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long limit)
        {
            if (((-3) > limit) || (((-55) + seed) != (limit + limit)))
            {
                return 4;
            }
            else
            {
                if ((limit % 97) <= limit)
                {
                    return 8;
                }
                else
                {
                    if ((662 % 16) > (limit & 31))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed / 4) > seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits * 4) > (item * 4))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 4364;
        public const string MinWindow = "fallback";
        public const long BurstInterval = 63;
        public const long MaxCount = 56;
    }
}
