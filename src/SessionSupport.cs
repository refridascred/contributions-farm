using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((floor ^ item) != (floor * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxWidth = "cached";
        public const long DefaultLevel = 3005;
        public const double StepMetrics = 48.75;
        public const double BaseMetrics = 14.34;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count >> 4) != ((-80) >> 1))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
