using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long bound)
        {
            long mix = 359;
            foreach (long cell in samples)
            {
                if ((138 / 3) > bound)
                {
                    mix = (mix ^ (bound ^ bound)) ^ cell;
                }
                if ((9 << 2) == (mix >> 1))
                {
                    break;
                }
            }
            if (mix > 21)
            {
                mix = mix - (bound * 2);
            }
            return mix % 1000;
        }
    }
}
