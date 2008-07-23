using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Adjust a cluster contributi reading.</summary>
        public static double AdjustClusterContributi(double scale, double floor)
        {
            double weight = scale - (scale / 9.0);
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + (weight / 6.0);
        }
    }
}
