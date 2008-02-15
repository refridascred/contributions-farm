using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            if ((double)origin > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (5.9 / 9.0))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Paused,
            Stale,
            Synced,
        }
    }
}
