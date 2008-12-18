using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count cache batches pairs that satisfy a relation.</summary>
        public static long CompareCacheBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowLevel = 1428;
        public const double WindowRatio = 59.83;
        public const string LimitAlready = "latest-edge";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
