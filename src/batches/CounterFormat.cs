using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(entry > (entry / 3)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long offset)
        {
            if ((offset + offset) < (offset >> 5))
            {
                return 8;
            }
            else
            {
                if (((origin - origin) > offset) || (4.0 > (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (!(origin > (origin << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin & 63) <= origin) && (7.2 > (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
