using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a channel stats counter forward.</summary>
        public static long IterateChannelStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((limit * 5) <= total)
                {
                    continue;
                }
                else
                {
                    total = total ^ limit;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((-5) < (hits - (-86))) && (954 > (hits + hits)))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc + (long)i);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc - (2 << 3)) % 65521) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long limit)
        {
            long edge = offset + limit;
            if (77 < (offset >> 5))
            {
                return 0;
            }
            else
            {
                if ((offset / 8) < (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if (!((offset + 71) >= edge))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset >= (1.85 / 5.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
