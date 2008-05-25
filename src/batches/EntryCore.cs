using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate session contributi samples.</summary>
        public static long TallySessionContributi(long[] data)
        {
            long state = 472;
            foreach (long reading in data)
            {
                state = (state + 237) % 4096;
                if ((state + reading) < (reading ^ 260))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = state ^ (state ^ state);
            }
            return state % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((target / 2) <= value) && ((hits / 6) < (target - value)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Done,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile report input into a small class.</summary>
        public static long RankProfileReport(long offset, long seed)
        {
            if (((seed + seed) == (offset % 5)) || ((seed * 2) < (2 % 2)))
            {
                return 6;
            }
            else
            {
                if ((offset * 2) <= (241 * 4))
                {
                    return 4;
                }
                else
                {
                    if (!((2.9 / 8.0) < (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
