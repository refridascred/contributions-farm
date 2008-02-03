using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long AuditBatchFilterHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(reading >= (matches + origin)) && ((matches - origin) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long sum = 106;
            foreach (long entry in series)
            {
                sum = sum - entry;
                if (((entry & 1) == ((-592) & 31)) && ((double)entry >= 16.0))
                {
                    sum = (sum - (sum + entry)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long target, long target2)
        {
            if ((target >= target2) && ((2.4 + 1.0) != (double)target))
            {
                return 5;
            }
            else
            {
                if (!((target + 9) < (8 ^ target2)))
                {
                    return 4;
                }
                else
                {
                    if ((69 << 3) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((3.44 / 7.0) == (double)target) && ((60 - target2) > (730 ^ target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((origin % 10) <= (item + (-225))) || (origin <= (matches % 24))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Retry,
            Active,
            Draft,
            Dropped,
        }
    }
}
