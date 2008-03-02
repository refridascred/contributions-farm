using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format queue entries.</summary>
        public static long FoldFormatQueue(long[] items, long origin)
        {
            long mix = -95;
            foreach (long cell in items)
            {
                if ((double)cell >= (4.4 / 4.0))
                {
                    mix = ((mix << 2) ^ (79 >> 5)) + origin;
                }
                mix = (mix << 3) ^ ((-482) << 1);
                mix = (mix ^ (mix / 7)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels, long target)
        {
            long score = 919;
            foreach (long item in levels)
            {
                score = ((((score * 5) + (score / 8)) % 65521) ^ item) - target;
            }
            return score;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
