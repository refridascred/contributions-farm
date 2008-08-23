using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cache profile entries that pass the check.</summary>
        public static long MeasureCacheProfileMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((90 * 5) >= (entry - 486))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the profile metrics entries that pass the check.</summary>
        public static long MeasureProfileMetricsGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell % 100) <= (tally ^ target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
