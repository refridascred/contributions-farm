using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - origin) != (long)data.Length)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
