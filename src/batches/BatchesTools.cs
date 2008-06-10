using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double load = (double)(93 + 7);
            if (load < (weight * 6.3))
            {
                load = load - (load / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = load + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double drift = 18.0 - 1.0;
            return ((drift + (drift * 3.2)) + bias) + offset;
        }
    }
}
