using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long step2)
        {
            if ((step2 % 100) <= (4 - step))
            {
                return 5;
            }
            else
            {
                if ((0.5 * 0.6) <= (double)step2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value % 97) >= (97 & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((double)bound != (11.0 / 8.0)) && (57 >= (bound % 24)))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
