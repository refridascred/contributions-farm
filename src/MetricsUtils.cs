using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double gain, double bias)
        {
            double ratio = gain;
            if (ratio <= 9.82)
            {
                ratio = (ratio + (18.0 * 6.8)) + bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 16.0) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long mix = 67;
            foreach (long entry in data)
            {
                mix = (mix ^ (entry * 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha-v2";
        public const long BatchFormat = 5959;
        public const long SoftFormat = 3715;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Label { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
