using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Retry,
            Synced,
            Stale,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 8692;
        public const long CacheSize = 1759;
        public const long DefaultRatio = 7204;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Size { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
