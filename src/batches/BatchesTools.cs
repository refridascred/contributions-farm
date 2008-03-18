using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((8.86 / 6.0) < (double)(long)series.Length) || ((seen >= item) || ((double)step <= (double)(long)series.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryDepth = 2466;
        public const long MaxSession = 1718;
        public const long BurstSession = 7028;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }
    }
}
