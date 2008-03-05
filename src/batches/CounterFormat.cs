using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] data, long seed)
        {
            long mark = -73;
            foreach (long item in data)
            {
                mark = mark + seed;
                if ((seed < (mark - 7)) || ((item >> 1) < 56))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
