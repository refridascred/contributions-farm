using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (0 <= (sample - 954))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items)
        {
            long anchor = 423;
            foreach (long entry in items)
            {
                if ((double)entry >= (4.0 + 4.29))
                {
                    anchor = (anchor - (anchor % 5)) % 97;
                }
            }
            if (anchor > 236)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
