using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Ready,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleSize = "cached-edge";
        public const double CacheWidth = 60.04;
        public const long BaseLevel = 2271;
        public const long BaseSize = 5344;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double drift = floor;
            if (drift > drift)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate / 5.0)) + (double)(long)i;
            }
            return drift + (double)505;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardScore = 2424;
        public const long BaseGithubfarm = 3456;
        public const long BurstGithubfarm = 2901;
        public const long RetrySize = 6166;
    }
}
