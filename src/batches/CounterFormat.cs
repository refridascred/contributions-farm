using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 31) <= (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((9.05 / 9.0) > (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
