using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the notes account entries that pass the check.</summary>
        public static long AuditNotesAccountMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)cell == (9.64 / 6.0)) || (matches >= (-748)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter schema value against two limits.</summary>
        public static long RankCounterSchema(long step, long bound)
        {
            if ((double)step > (5.9 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((double)step != (2.7 + 4.5))
                {
                    return 8;
                }
                else
                {
                    if ((bound > (step - step)) || ((step + 686) > bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((768 + step) != (step + 46))
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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Done,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell <= (double)matches) && ((4.93 + 0.2) < (double)cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
