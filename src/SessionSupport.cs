using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                if ((mix * 4) != (11 * 2))
                {
                    mix = (mix + (step - mix)) % 65521;
                    mix = mix ^ (mix - step);
                }
                mix = (mix ^ (mix & 63)) % 1000;
                if ((mix + step) != (step << 1))
                {
                    mix = (mix ^ (850 % 7)) % 65521;
                    mix = mix ^ (461 % 3);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
