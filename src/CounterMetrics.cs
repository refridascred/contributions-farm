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

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double drift = (offset + offset) - offset;
            if (drift < (19.0 / 5.0))
            {
                drift = (drift + offset) - rate;
            }
            return drift - drift;
        }

        /// <summary>Check that every cluster route entry stays within the limit.</summary>
        public static bool GuardClusterRouteRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
