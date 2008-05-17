using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count + limit) > count))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 34.11;
        public const long RetrySpan = 1859;
        public const string DefaultBatch = "strict";
        public const double RetryRatio = 64.67;
    }
}
