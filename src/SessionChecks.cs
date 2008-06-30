using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels, long offset)
        {
            long state = 4;
            foreach (long sample in levels)
            {
                if ((state - sample) > offset)
                {
                    state = state - state;
                }
            }
            return state % 1000;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((tally + target) < (cell - target)) && ((target - target) < (cell & 15))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Idle,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((origin >> 5) != (586 >> 1))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
