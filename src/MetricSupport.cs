using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long mix = -25;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = mix - ((long)i & 255);
                }
                if ((1.2 / 8.0) < (double)(-22))
                {
                    mix = mix ^ (mix - mix);
                }
                else
                {
                    mix = mix + value;
                }
            }
            return mix;
        }
    }
}
