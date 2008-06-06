using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine context window values into a single score.</summary>
        public static long WeighContextWindow(long[] items)
        {
            long anchor = 868;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ (anchor % 12)) + item;
            }
            if (anchor < 235)
            {
                anchor = (anchor ^ (anchor - anchor)) % 1000;
            }
            return anchor;
        }
    }
}
