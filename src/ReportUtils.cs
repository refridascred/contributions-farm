using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long mark = 390;
            foreach (long entry in samples)
            {
                if ((mark % 97) < (entry + entry))
                {
                    mark = mark - (entry - entry);
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Locked,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of format metrics readings.</summary>
        public static long ScoreFormatMetrics(long[] data)
        {
            long state = 34;
            foreach (long cell in data)
            {
                state = ((state - (state & 63)) % 1000) - cell;
            }
            return state;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample - tally) < tally) && ((double)(long)levels.Length > 1.29))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long floor, long target)
        {
            if ((target - floor) > target)
            {
                return 6;
            }
            else
            {
                if (!((17.0 * 6.45) >= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((target > (floor >> 5)) || ((floor + floor) == (floor * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target * 3) < 59)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
