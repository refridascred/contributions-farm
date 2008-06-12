using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank cluster graph input into a small class.</summary>
        public static long RankClusterGraph(long seed, long target)
        {
            if (((double)seed < (9.21 - 3.28)) || ((double)target <= (4.6 / 2.0)))
            {
                return 1;
            }
            else
            {
                if (target >= seed)
                {
                    return 3;
                }
                else
                {
                    if ((67 - seed) != (target % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed << 3) != (seed + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item + count) > (item & 63))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((11.0 * 6.95) == (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
