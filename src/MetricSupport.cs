using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stream editor entries.</summary>
        public static long CombineStreamEditor(long[] items)
        {
            long state = 5;
            foreach (long item in items)
            {
                if ((4.0 + 2.0) != (double)state)
                {
                    state = state ^ state;
                }
                if ((843 + item) >= (state + state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchTimeout = 39.72;
        public const long WindowSchema = 9703;
        public const double BatchRatio = 17.84;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
