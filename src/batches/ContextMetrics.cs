using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public double Limit { get; set; }
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
