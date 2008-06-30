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

        /// <summary>Audit cache checks readings against a rule.</summary>
        public static long CountCacheChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell + tally) <= (cell / 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (88 >= (matches - step))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
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
