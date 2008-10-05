using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((5.2 + 9.68) > (double)(long)items.Length))
                {
                    matches = ((matches + 2) + sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "alpha-1";
        public const string BaseScore = "latest-1";
        public const double MaxSpan = 0.77;
    }
}
