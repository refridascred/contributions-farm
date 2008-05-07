using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) > entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long step)
        {
            long edge = seed + step;
            if ((step * 5) > (step + step))
            {
                return 5;
            }
            else
            {
                if (((90 + seed) > (seed & 7)) && ((30 * 3) > (0 + edge)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
