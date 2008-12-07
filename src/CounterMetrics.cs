using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Active,
            New,
            Paused,
            Queued,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double scale = bias;
            if (scale < bias)
            {
                scale = scale + (double)4;
            }
            else
            {
                scale = scale + (gain - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (double)115;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Retry,
            Stale,
            Dropped,
            Draft,
        }
    }
}
