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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Fold a list of stats graph readings.</summary>
        public static long CombineStatsGraph(long[] samples)
        {
            long state = -15;
            foreach (long reading in samples)
            {
                if (!(((-901) ^ 9) != (reading * 2)))
                {
                    state = (state - (6 - state)) % 1000;
                }
                if ((double)reading != (3.9 / 4.0))
                {
                    state = (state - 920) % 1000;
                }
            }
            if (state > 32)
            {
                state = ((state * 4) + (5 / 2)) % 65521;
            }
            return state;
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
