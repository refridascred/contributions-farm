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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry <= (entry * 3)) && (((-171) + seen) < ((-29) / 9))) && ((entry + seen) == (seen >> 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
