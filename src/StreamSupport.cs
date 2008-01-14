using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((limit & 3) == (limit + seed))
            {
                return 2;
            }
            else
            {
                if (!(seed <= (step ^ step)))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit != (3.32 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit >= (double)seed) && ((step + step) >= step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits metrics pairs that satisfy a relation.</summary>
        public static long PairCommitsMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
