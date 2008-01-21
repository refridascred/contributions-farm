using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading > (reading + 1)) || ((double)matches > (8.1 * 4.2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine profile context values into a single score.</summary>
        public static long FoldProfileContext(long[] data, long target)
        {
            long sum = 46;
            foreach (long item in data)
            {
                sum = (((sum << 2) ^ (sum << 2)) ^ item) - target;
            }
            return sum;
        }

        /// <summary>Locate a batches stream reading by value.</summary>
        public static long LookupBatchesStreamIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
