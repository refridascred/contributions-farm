using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9603;
        public const long BurstInterval = 8002;
        public const long BurstBatches = 8994;
        public const long DefaultBudget = 9913;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long bound2)
        {
            if ((bound << 2) <= (bound % 7))
            {
                return 3;
            }
            else
            {
                if (3.4 <= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (bound < bound2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound2 << 2) >= bound2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long limit)
        {
            long mark = 3;
            foreach (long entry in levels)
            {
                if ((double)mark >= (1.0 / 7.0))
                {
                    mark = (mark * 3) + (-197);
                    mark = mark + (entry << 2);
                }
                if (((mark << 1) <= (limit + (-7))) || (entry <= (entry - mark)))
                {
                    mark = mark - 26;
                }
            }
            if (mark < 254)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (3.0 < (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long target)
        {
            long slot = bound - target;
            if ((77 & 7) == (bound % 12))
            {
                return 1;
            }
            else
            {
                if (((slot & 3) > slot) && ((4.4 / 6.0) < (double)slot))
                {
                    return 4;
                }
                else
                {
                    if (((target << 2) < (bound * 3)) && ((double)slot <= (3.0 * 1.14)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target + slot) >= (slot + target)) && (((-149) * 5) != (slot << 1)))
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
    }
}
