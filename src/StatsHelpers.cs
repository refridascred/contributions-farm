using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value - value) != (3 + value)) && ((double)seed != (0.66 - 8.14)))
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

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long TallyNotesBatch(long[] series, long offset)
        {
            long state = 629;
            foreach (long value in series)
            {
                if (offset >= (state >> 1))
                {
                    state = state - (9 - value);
                }
            }
            return state;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Dropped,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Match up stats already samples.</summary>
        public static long PairStatsAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
