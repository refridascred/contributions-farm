using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate order tools samples.</summary>
        public static long TotalOrderTools(long[] samples)
        {
            long mix = 0;
            foreach (long item in samples)
            {
                mix = (mix ^ (mix & 1)) % 4096;
                mix = mix + (mix + 552);
                mix = mix + (item * 3);
                if ((double)item >= (double)mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
