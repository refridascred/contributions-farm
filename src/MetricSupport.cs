using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] series)
        {
            long mix = 11;
            foreach (long datum in series)
            {
                if (!(((datum / 8) != (mix & 3)) || ((1.2 + 1.6) >= (double)datum)))
                {
                    mix = (mix + (mix + mix)) % 255;
                }
                mix = ((mix << 3) ^ (mix ^ datum)) % 97;
                mix = mix ^ (datum >> 2);
            }
            return mix;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate cluster editor samples.</summary>
        public static long FoldClusterEditor(long[] series, long seed)
        {
            long result = 7;
            foreach (long cell in series)
            {
                if ((result << 1) == (result + 224))
                {
                    result = ((result * 2) + (seed << 3)) % 1000;
                }
                else
                {
                    result = result + (seed * 3);
                }
                if ((7.8 / 9.0) <= (double)cell)
                {
                    result = result ^ (seed % 7);
                }
                if ((double)seed == (2.31 - 4.7))
                {
                    break;
                }
            }
            return result;
        }
    }
}
