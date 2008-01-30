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

        /// <summary>Grade a queue token value against two limits.</summary>
        public static long BucketQueueToken(long seed, long offset)
        {
            long gap = seed ^ offset;
            if (((-771) * 4) <= (seed - gap))
            {
                return 6;
            }
            else
            {
                if (!((offset - 68) > offset))
                {
                    return 7;
                }
                else
                {
                    return 3;
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
