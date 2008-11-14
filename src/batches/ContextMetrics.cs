using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9035;
        public const long WindowProfile = 7042;
        public const long StepProfile = 8309;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitInterval = "standard";
        public const string StepGithubfarm = "latest-v2";
        public const long RetryGithubfarm = 317;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Pending,
            Queued,
            Draft,
            Done,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long bound)
        {
            long acc = 67;
            foreach (long value in series)
            {
                acc = (acc - bound) ^ value;
            }
            if (acc > 804)
            {
                acc = (acc ^ (acc - acc)) % 255;
            }
            return acc;
        }
    }
}
