using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((count ^ count) >= value) || ((double)862 > (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
