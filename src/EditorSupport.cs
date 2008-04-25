using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of farm notes entries.</summary>
        public static long WeighFarmNotes(long[] readings)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                total = total ^ (total + sample);
                for (int i = 0; i < 2; i++)
                {
                    total = ((total * 2) + 51) + (long)i;
                }
                total = (total + (total + sample)) % 1000;
            }
            return total;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long target, long offset)
        {
            long prev = target ^ offset;
            if ((prev + prev) >= prev)
            {
                return 3;
            }
            else
            {
                if (!((offset >> 1) < target))
                {
                    return 6;
                }
                else
                {
                    if (!(offset > (37 % 64)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3 - offset) <= prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data)
        {
            long total = 47;
            foreach (long entry in data)
            {
                total = (total + (total * 5)) ^ entry;
            }
            return total;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long bound)
        {
            if ((bound + 361) <= (bound / 6))
            {
                return 2;
            }
            else
            {
                if ((origin / 5) <= (356 * 2))
                {
                    return 8;
                }
                else
                {
                    if (bound < (bound + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((1.56 > (double)seen) || ((double)cell > (3.79 / 9.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
