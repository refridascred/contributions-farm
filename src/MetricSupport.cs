using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)origin <= (7.3 - 9.9)) || (1 >= origin))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) != (reading + 9))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Active,
            Idle,
        }
    }
}
