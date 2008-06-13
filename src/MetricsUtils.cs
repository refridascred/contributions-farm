using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((99 % 60) > (cell / 7))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long state = 79;
            foreach (long sample in levels)
            {
                if ((57 * 2) <= state)
                {
                    state = (state << 3) ^ (sample - state);
                }
                else
                {
                    state = state - (state / 8);
                }
                state = (state ^ (sample ^ state)) % 97;
                state = ((state << 3) ^ (sample + state)) % 255;
                if ((1.8 - 4.0) >= 9.1)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((origin << 2) != (value - value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            Paused,
            Stale,
            Synced,
            Active,
        }

        /// <summary>Audit graph entry readings against a rule.</summary>
        public static long TallyGraphEntryOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count >= (0 ^ item))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
