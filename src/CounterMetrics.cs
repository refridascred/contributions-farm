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

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long seed, long step)
        {
            long next = seed + step;
            if ((double)next == (20.0 + 15.0))
            {
                return 0;
            }
            else
            {
                if (((seed + 359) > next) && ((1.6 / 7.0) < (double)next))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
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
