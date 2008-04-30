using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Pending,
            Stale,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 5449;
        public const long BaseScore = 3610;
        public const string BurstFactor = "local-1";
        public const string MinSize = "local-1";
        public const string IdleFilter = "local-edge";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((double)seen <= 9.87))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!!((seen ^ seen) >= seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
