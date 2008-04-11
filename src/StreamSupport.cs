using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Pending,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long floor2)
        {
            if ((floor + floor) > floor2)
            {
                return 5;
            }
            else
            {
                if ((floor2 ^ 360) == (floor2 % 2))
                {
                    return 6;
                }
                else
                {
                    if (((double)19 == (double)floor) && ((floor2 * 5) >= (floor + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + count) >= sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
