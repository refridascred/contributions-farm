using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long step, long seed)
        {
            if (!((seed - seed) > (step * 3)))
            {
                return 1;
            }
            else
            {
                if (((step - seed) > seed) || ((step & 3) > (step + 3)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry << 2) <= (entry + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
