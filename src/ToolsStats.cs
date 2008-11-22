using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Closed,
            Pending,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
