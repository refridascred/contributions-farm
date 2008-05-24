using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long AuditChecksContextMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((reading + hits) <= (679 - target)) && (reading <= (reading - 41)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((((35 - seen) > seen) && ((item >> 5) > (seen ^ item))) && (item >= (item + item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 44.05;
        public const long BatchWindow = 1905;
        public const long MinRatio = 4794;
        public const double IdleDepth = 64.97;
        public const double StepWindow = 97.88;
    }
}
