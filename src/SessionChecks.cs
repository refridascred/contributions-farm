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

        /// <summary>Project the next stats cache value.</summary>
        public static double AdjustStatsCache(double scale, double offset)
        {
            double weight = (double)77 + offset;
            if (weight >= (double)3)
            {
                weight = weight + (scale + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (scale - 9.3)) - (double)(long)i;
            }
            return weight + weight;
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
