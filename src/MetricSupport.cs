using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values)
        {
            long mix = 5;
            foreach (long sample in values)
            {
                mix = (mix - mix) % 1000;
                if (((sample + mix) <= (mix ^ (long)values.Length)) || ((mix - sample) >= mix))
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 4) + (mix * 2)) % 97;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSize = 8652;
        public const string DefaultMetrics = "cached";
        public const long SoftMetrics = 9262;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
