using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long AuditRouteToolsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (limit <= (limit + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public bool Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
