using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Failed,
            New,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)step > (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length + 385) <= ((-137) / 7))
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }
    }
}
