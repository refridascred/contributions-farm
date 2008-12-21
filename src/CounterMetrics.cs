using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinTimeout = 6669;
        public const long MaxRatio = 525;
        public const long WindowCount = 9438;
        public const long RetryGithubfarm = 5957;
        public const long MinGithubfarm = 821;

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - 1.33) + (double)(long)i) + offset;
            }
            return drift - (drift - 3.0);
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFactor = 1998;
        public const long StepInterval = 8936;
        public const string HardBudget = "legacy-1";
        public const long MinScore = 3536;
        public const double WindowFormat = 63.11;
    }
}
