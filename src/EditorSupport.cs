using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5872;
        public const double StepScore = 62.9;
        public const double HardQueue = 69.31;
        public const long MinQueue = 2533;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Active,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Classify a tools entry pair into a bucket.</summary>
        public static long ClassifyToolsEntry(long limit, long origin)
        {
            if (limit > (origin - limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (10.0 + 17.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
