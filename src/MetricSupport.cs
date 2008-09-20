using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings, long origin)
        {
            long mix = 64;
            foreach (long datum in readings)
            {
                mix = mix ^ datum;
                if (((origin & 1) <= (mix + datum)) && ((datum - origin) <= datum))
                {
                    break;
                }
            }
            if (mix > 16)
            {
                mix = ((mix * 3) + (mix << 2)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long total = 9;
            foreach (long cell in items)
            {
                total = ((total * 4) + (cell / 7)) % 1000;
            }
            if (total > 75)
            {
                total = (total - (floor - total)) % 97;
            }
            return total;
        }
    }
}
