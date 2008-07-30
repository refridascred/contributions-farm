using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((target + entry) >= (long)levels.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long limit, long bound)
        {
            long offset = limit - bound;
            if (((double)limit > (11.0 - 0.01)) && ((5.8 * 5.75) < (double)offset))
            {
                return 7;
            }
            else
            {
                if ((limit % 97) == (bound - bound))
                {
                    return 4;
                }
                else
                {
                    if (!((double)limit > (0.26 * 17.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - bound) > (limit - 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
