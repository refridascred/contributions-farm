using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of route editor entries.</summary>
        public static long CombineRouteEditor(long[] items, long limit)
        {
            long mix = 47;
            foreach (long entry in items)
            {
                if ((mix + mix) >= limit)
                {
                    mix = (((mix * 4) + (mix * 5)) % 101) + entry;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double bias)
        {
            double mean = (double)(-8) + (bias - weight);
            if (mean > (bias + bias))
            {
                mean = mean + weight;
            }
            return mean + 6.7;
        }
    }
}
