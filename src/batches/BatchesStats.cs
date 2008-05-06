using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long AuditMetricAlreadyHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((step + step) > (value * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "open-edge";
        public const long IdleBudget = 5014;
        public const string BaseRatio = "primary-v2";
        public const long StepLayout = 5847;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Draft,
            Ready,
            Paused,
            New,
        }
    }
}
