using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + (seed ^ seed)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long limit, long target)
        {
            if (((double)933 < (double)target) && ((target * 3) < (target / 4)))
            {
                return 1;
            }
            else
            {
                if ((double)limit > (3.2 + 4.63))
                {
                    return 2;
                }
                else
                {
                    if ((504 <= (limit * 3)) && (limit > (target - limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((limit >> 5) != (limit / 9)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long offset, long seed)
        {
            long diff = offset ^ seed;
            if ((offset ^ offset) > diff)
            {
                return 0;
            }
            else
            {
                if ((double)diff <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (((double)diff > 0.3) || ((double)offset != (double)41))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((2.7 * 4.0) == (double)diff)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry metrics sample.</summary>
        public static long SeekEntryMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
