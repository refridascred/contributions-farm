using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value >> 2) <= (seen << 1)) && !((value & 3) <= (value % 10)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((limit >= entry) && (((long)values.Length % 10) <= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long target)
        {
            long state = 586;
            foreach (long reading in readings)
            {
                if (!((double)state >= (1.2 - 1.4)))
                {
                    state = (((state * 2) + (target + 271)) % 1000) + reading;
                }
                else
                {
                    state = ((state * 2) + (state + state)) % 101;
                }
            }
            return state % 1000;
        }
    }
}
