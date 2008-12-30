using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a cluster cache value against two limits.</summary>
        public static long ClassifyClusterCache(long origin, long target)
        {
            long slot = origin + target;
            if ((double)slot <= (5.0 + 3.8))
            {
                return 6;
            }
            else
            {
                if ((target + slot) <= slot)
                {
                    return 5;
                }
                else
                {
                    if ((slot ^ slot) < (slot + (-4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin << 1) <= (origin & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long offset2)
        {
            if (offset2 > offset)
            {
                return 1;
            }
            else
            {
                if ((offset ^ offset2) < 577)
                {
                    return 6;
                }
                else
                {
                    if ((6.8 * 6.19) > (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset2 > (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (acc >> 5)) % 4096;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc << 2) ^ (step % 5)) % 1000) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) < (datum / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long AuditChecksBatchMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item * 2) < (seen << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
