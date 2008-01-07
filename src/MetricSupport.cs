using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] samples)
        {
            long mix = 419;
            foreach (long sample in samples)
            {
                if (sample <= (sample * 3))
                {
                    mix = (mix + (mix + mix)) % 4096;
                    mix = (mix << 3) ^ (mix & 63);
                    break;
                }
                if (!((7.1 / 2.0) > (4.0 - 8.77)))
                {
                    mix = ((mix * 5) + 928) % 4096;
                }
            }
            if (mix > 306)
            {
                mix = mix - (mix - mix);
            }
            return mix;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
