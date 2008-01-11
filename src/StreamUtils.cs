using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 1267;
        public const long SoftRecord = 3699;
        public const double MaxBudget = 51.69;
        public const string SoftBudget = "cached";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Draft,
            Active,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            New,
            Paused,
            Failed,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((0.6 + 2.4) != (double)(long)items.Length)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Queued,
            Synced,
            Pending,
        }
    }
}
