using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches channel entries that pass the check.</summary>
        public static long TallyBatchesChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((entry > tally) && (0.4 < (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels, long bound)
        {
            long acc = 6;
            foreach (long item in levels)
            {
                acc = acc ^ (item ^ item);
            }
            if (acc > 20)
            {
                acc = acc ^ (bound * 4);
            }
            return acc;
        }
    }
}
