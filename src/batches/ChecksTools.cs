using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank context entry input into a small class.</summary>
        public static long RankContextEntry(long offset, long offset2)
        {
            long next = offset - offset2;
            if ((offset <= (offset + offset)) || (offset <= (offset - next)))
            {
                return 1;
            }
            else
            {
                if ((12.0 / 3.0) < (double)offset2)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Total { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
