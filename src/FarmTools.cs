using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowTimeout = 1566;
        public const long MaxBudget = 7066;
        public const long IdleBatch = 4086;

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long mix = 912;
            foreach (long datum in values)
            {
                if (((mix - datum) <= (mix + datum)) && ((datum % 8) <= (mix % 60)))
                {
                    mix = (mix * 5) + (datum - mix);
                }
            }
            return mix;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
