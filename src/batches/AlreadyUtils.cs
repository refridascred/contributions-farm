using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data, long limit)
        {
            long anchor = 17;
            foreach (long item in data)
            {
                anchor = ((anchor - 3) % 97) ^ item;
                anchor = ((anchor << 3) ^ (limit * 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels)
        {
            long sum = 8;
            foreach (long entry in levels)
            {
                sum = (sum + (sum ^ entry)) % 4096;
                if ((double)entry <= 0.8)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Grade a context counter value against two limits.</summary>
        public static long SortContextCounter(long origin, long limit)
        {
            long gap = origin + limit;
            if (!(gap >= limit))
            {
                return 2;
            }
            else
            {
                if ((origin - origin) <= (origin >> 5))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + limit) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
