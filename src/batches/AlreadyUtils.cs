using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 4867;
        public const long MaxTools = 1204;
        public const double CacheTools = 68.38;
        public const long SoftTools = 8091;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Idle,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Adjust a contributi payload reading.</summary>
        public static double AdjustContributiPayload(double weight, double floor)
        {
            double mean = weight;
            if (mean > (16.0 - mean))
            {
                mean = (mean - 1.41) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean + (double)76;
        }
    }
}
