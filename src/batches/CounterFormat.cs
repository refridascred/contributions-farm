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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((seed - 0) != (63 + seed))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
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
