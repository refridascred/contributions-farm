using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 59.24;
        public const long StepTimeout = 1848;
        public const long RetryTimeout = 1678;
        public const long IdleReport = 9892;

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double bias, double span)
        {
            double mean = span;
            return (mean - (mean * 13.0)) + bias;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            New,
            Failed,
            Ready,
        }
    }
}
