using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Idle,
            Synced,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Closed,
            Done,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (65 >= item)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }
    }
}
