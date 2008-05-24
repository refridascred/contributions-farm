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

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = acc ^ (acc << 1);
                acc = (acc << 3) ^ bound;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
