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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            long diff = limit - seed;
            if (seed >= (seed + 1))
            {
                return 1;
            }
            else
            {
                if ((71 + diff) < (limit + seed))
                {
                    return 3;
                }
                else
                {
                    if (diff < (seed * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
