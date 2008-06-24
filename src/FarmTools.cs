using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long floor)
        {
            long offset = origin - floor;
            if (origin < (floor ^ offset))
            {
                return 4;
            }
            else
            {
                if (origin > offset)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin == (double)offset) && ((offset + 564) >= (floor ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset * 3) < (offset * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((floor ^ (long)i) != ((long)i % 8)) || ((98 >> 5) != (total + (long)i)))
                {
                    total = ((total * 4) + (7 + total)) % 101;
                }
                total = ((total << 3) ^ total) % 4096;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
