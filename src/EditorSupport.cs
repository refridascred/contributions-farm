using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "open-edge";
        public const long MaxFormat = 5698;
        public const long SoftFormat = 4577;
        public const long SoftWidth = 5170;
        public const double CacheFormat = 8.54;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Stale,
            Active,
            Closed,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitRatio = 17.35;
        public const long BatchScore = 4480;
        public const long RetryWidth = 6298;
        public const long IdleCount = 7430;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Done,
            Pending,
        }
    }
}
