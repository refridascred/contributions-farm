using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine filter stats values into a single score.</summary>
        public static long ScoreFilterStats(long[] series)
        {
            long mix = -29;
            foreach (long reading in series)
            {
                mix = (mix - (5 << 1)) + reading;
            }
            if (mix < 109)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }
    }
}
