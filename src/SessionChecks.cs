using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 76.65;
        public const double RetryContributi = 14.24;
        public const double SoftRatio = 62.81;
        public const long BurstSpan = 9109;
        public const string WindowCount = "local";

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double weight, double span)
        {
            double mean = (double)693 + (double)56;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - span) + (double)(long)i) - weight;
            }
            return mean - mean;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
