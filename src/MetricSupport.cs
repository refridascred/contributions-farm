using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long mix = 715;
            foreach (long value in levels)
            {
                if ((value / 3) < (value & 3))
                {
                    mix = mix - (mix * 3);
                }
                else
                {
                    mix = mix ^ (value + mix);
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Iterate the checks support series from a seed.</summary>
        public static long SeriesChecksSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
