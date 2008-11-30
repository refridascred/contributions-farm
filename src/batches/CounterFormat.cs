using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long mix = 77;
            foreach (long entry in levels)
            {
                if (!((55 + entry) < mix))
                {
                    mix = ((mix * 3) + (mix ^ entry)) % 4096;
                }
                if ((52 >> 4) >= (mix - mix))
                {
                    mix = (mix + (mix % 3)) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
