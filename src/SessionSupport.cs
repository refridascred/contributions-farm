using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many layout notes samples are out of range.</summary>
        public static long CountLayoutNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)cell >= (13.0 + 16.0)) || (seen >= (seen ^ cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long origin)
        {
            if (origin >= (limit + origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin < (0.48 - 7.7))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long AuditFarmEntryMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - sample) != (sample - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
