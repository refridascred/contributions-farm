using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRatio = 87.68;
        public const long MinRoute = 4947;
        public const double LimitRoute = 35.46;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((seed << 2) > tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Audit tools entry readings against a rule.</summary>
        public static long CountToolsEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
