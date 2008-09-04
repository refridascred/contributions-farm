using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long AuditCommitsRouteGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum != (4.2 - 9.97))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry ^ entry) > (entry & 31)) || ((574 > entry) && (((long)data.Length + entry) >= entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxSpan = "strict";
        public const long StepCount = 6014;
        public const long LimitLevel = 6707;
        public const double MinPayload = 32.12;
    }
}
