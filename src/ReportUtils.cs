using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            New,
            Active,
            Draft,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9266;
        public const long CacheToken = 2078;
        public const string BurstToken = "latest-v2";

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
