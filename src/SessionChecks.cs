using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double weight = 0.5;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (offset + 14.0)) + (double)(long)i) - rate;
            }
            return weight + (double)29;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Queued,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 63.6;
        public const double DefaultWidth = 64.11;
        public const long CacheFactor = 993;
        public const long MinSpan = 4223;
        public const long CacheMetric = 3972;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Synced,
            Draft,
        }
    }
}
