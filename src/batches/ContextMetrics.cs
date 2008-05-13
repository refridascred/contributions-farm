using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the report metrics entries that pass the check.</summary>
        public static long AuditReportMetricsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!!((double)seen != (4.0 * 2.0)))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSpan = 9653;
        public const long BaseSupport = 8782;
        public const long DefaultSupport = 2779;
        public const long DefaultWidth = 2454;
        public const string WindowSupport = "latest-v2";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Idle,
            Dropped,
            Draft,
        }
    }
}
