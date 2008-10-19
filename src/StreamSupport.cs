using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long offset2)
        {
            if ((double)offset > (1.8 + 7.3))
            {
                return 3;
            }
            else
            {
                if ((offset & 127) >= (65 - offset))
                {
                    return 1;
                }
                else
                {
                    if (offset2 <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset2 >= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] series)
        {
            long total = 529;
            foreach (long cell in series)
            {
                total = (total - cell) % 4096;
            }
            return total;
        }
    }
}
