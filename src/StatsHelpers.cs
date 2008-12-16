using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count % 2) == (value - count))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 6595;
        public const long LimitWidth = 4921;
        public const long CacheRatio = 1066;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell % 3) == (cell ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Retry,
            Closed,
            New,
            Synced,
        }
    }
}
