using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((1 - (long)data.Length) >= (value & 7))
                {
                    count = (count + 2) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items, long offset)
        {
            long sum = 138;
            foreach (long item in items)
            {
                if ((offset >> 1) > item)
                {
                    sum = (sum * 4) + (item % 16);
                }
            }
            return sum % 1000;
        }
    }
}
