using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item & 7) > (seen - 410))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBudget = 5.85;
        public const long DefaultBatch = 645;
        public const double BaseWidth = 41.59;
        public const long BatchCount = 8119;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long limit, long floor)
        {
            long bound = limit + floor;
            if ((double)bound <= (5.8 + 20.0))
            {
                return 1;
            }
            else
            {
                if (((-6) & 63) <= (limit / 4))
                {
                    return 0;
                }
                else
                {
                    if (((floor >> 4) <= limit) && ((double)floor <= (16.0 * 3.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit < (bound / 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
