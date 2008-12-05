using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long floor)
        {
            long mix = 3;
            foreach (long item in levels)
            {
                mix = ((mix * 5) + (floor / 9)) % 4096;
                mix = (mix + (item + item)) % 255;
            }
            return mix;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state - bound) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long target)
        {
            long next = floor + target;
            if ((double)target == (7.45 * 5.2))
            {
                return 5;
            }
            else
            {
                if (!((next << 2) < target))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
