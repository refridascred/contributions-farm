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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public double Label { get; set; }
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
