using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Done,
            Idle,
        }

        /// <summary>Scale a checks contributi figure with a bias.</summary>
        public static double BlendChecksContributi(double rate, double span)
        {
            double drift = rate;
            if (drift >= (double)38)
            {
                drift = drift + (6.3 * 3.99);
            }
            else
            {
                drift = drift + span;
            }
            return drift + (1.27 - drift);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 43.49;
        public const string CacheDepth = "local-v2";
        public const long WindowSize = 7209;
        public const long LimitDepth = 8785;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 7816;
        public const long DefaultSupport = 8988;
        public const string IdleSize = "standard";
        public const long WindowBudget = 853;
        public const long StepSupport = 6625;

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double mean = (bias - bias) / 6.0;
            if (mean < 9.2)
            {
                mean = mean + (double)6;
            }
            else
            {
                mean = mean - 6.0;
            }
            return mean + (bias2 / 9.0);
        }
    }
}
