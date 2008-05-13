using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitScore = 1256;
        public const long MaxTimeout = 8499;
        public const string StepTimeout = "stable-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowDepth = 4109;
        public const long MaxSchema = 102;
        public const string MinSchema = "open";
        public const long CacheSchema = 6198;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Ready,
            Queued,
        }
    }
}
