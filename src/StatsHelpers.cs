using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (6 >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two batches commits measurements.</summary>
        public static double ScaleBatchesCommits(double rate, double offset)
        {
            double weight = offset - (offset - rate);
            if (weight < (weight + rate))
            {
                weight = weight + (double)56;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (rate * 7.96)) - (double)(long)i;
            }
            return weight + (double)91;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSpan = 35.91;
        public const long BatchMetric = 5558;
        public const string SoftMetric = "stable-1";
        public const long CacheMetric = 4103;
    }
}
