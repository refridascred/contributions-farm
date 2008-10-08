using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 5721;
        public const string MinSession = "cached-v2";
        public const long MaxSize = 1388;

        /// <summary>Check that every entry record entry stays within the limit.</summary>
        public static bool GuardEntryRecordLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
