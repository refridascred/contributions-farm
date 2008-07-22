using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first payload context entry that matches the target.</summary>
        public static long SeekPayloadContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((datum + 491) != (925 + 122)) || (959 > (seen + seen))) || !((double)datum < (0.8 * 9.32)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank tools cache input into a small class.</summary>
        public static long RankToolsCache(long floor, long target)
        {
            if (target <= (floor + 40))
            {
                return 3;
            }
            else
            {
                if ((floor & 7) <= (target + 6))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
