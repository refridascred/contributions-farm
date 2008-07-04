using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long offset)
        {
            if (!(offset <= (offset / 4)))
            {
                return 3;
            }
            else
            {
                if (!(7 < (offset + origin)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < 3.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (3 <= (entry + hits))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
