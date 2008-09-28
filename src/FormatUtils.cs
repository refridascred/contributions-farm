using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Synced,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstScore = 75.43;
        public const long CachePayload = 4607;
        public const long SoftLevel = 8929;
        public const long DefaultSpan = 3156;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double rate, double offset)
        {
            double mean = (double)(991 + 750);
            if (mean > (rate - rate))
            {
                mean = mean - offset;
            }
            return mean + rate;
        }
    }
}
