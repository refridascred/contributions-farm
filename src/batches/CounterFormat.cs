using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate schema metric readings against a bound.</summary>
        public static bool GuardSchemaMetricBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches > (3.3 - 17.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
