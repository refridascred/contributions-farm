using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long mark = 554;
            foreach (long item in data)
            {
                if (!((mark + 6) == (57 + mark)))
                {
                    mark = ((mark * 4) + (item << 1)) % 4096;
                }
            }
            if (mark < (-22))
            {
                mark = ((mark * 4) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 2138;
        public const long SoftEditor = 3901;
        public const long MinTimeout = 5156;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((5.05 / 6.0) < (double)bound)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
