using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - 754) != (reading % 8))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate cluster layout readings against a bound.</summary>
        public static bool ValidateClusterLayoutBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 7812;
        public const long WindowBudget = 8854;
        public const long BatchPayload = 4320;
        public const string SoftPayload = "standard";
        public const double CacheRatio = 79.14;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Done,
            Queued,
            Retry,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 7223;
        public const double BatchCluster = 26.13;
        public const double MinCluster = 93.04;
        public const string DefaultLevel = "alpha-edge";
        public const long LimitLevel = 2251;
    }
}
