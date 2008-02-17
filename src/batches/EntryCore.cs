using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long floor, long target)
        {
            if ((target + target) < floor)
            {
                return 1;
            }
            else
            {
                if ((floor % 3) < (floor % 12))
                {
                    return 3;
                }
                else
                {
                    if ((target << 3) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.0 + 8.29) != (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi already entries that pass the check.</summary>
        public static long CountContributiAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((689 + item) == (496 ^ tally)) && (((item + tally) >= (tally - 546)) && ((double)item == (3.8 + 3.04))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < (10.0 - 7.3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((19.0 * 4.51) != (double)target) || ((8.2 * 4.1) != (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            Locked,
            Done,
            Active,
            Stale,
        }
    }
}
