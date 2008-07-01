using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every payload window entry stays within the limit.</summary>
        public static bool GuardPayloadWindowRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Dropped,
            New,
            Active,
        }
    }
}
