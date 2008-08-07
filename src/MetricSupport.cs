using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((1.5 - 4.0) >= (double)datum)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((33 * 5) >= (item * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
