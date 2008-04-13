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

        /// <summary>Grade a format notes value against two limits.</summary>
        public static long BucketFormatNotes(long floor, long target)
        {
            long delta = floor ^ target;
            if ((13 << 2) > (delta + (-14)))
            {
                return 7;
            }
            else
            {
                if (delta < (delta << 2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
