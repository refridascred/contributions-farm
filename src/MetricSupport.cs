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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + origin) % 4096;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
