using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepSize = "fallback-edge";
        public const long LimitCommits = 1313;
        public const long CacheCommits = 3697;
        public const long MaxCommits = 1359;
        public const long SoftRatio = 1992;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (origin <= (659 - 7))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
