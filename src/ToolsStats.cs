using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long floor)
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

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series)
        {
            long acc = 420;
            foreach (long sample in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc - (58 / 9)) + (long)i;
                }
                acc = acc - (acc % 7);
                if (((double)acc < (4.3 + 13.0)) && ((acc + sample) == (acc ^ acc)))
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((16.0 / 8.0) != (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleBudget = 8624;
        public const long IdleWidth = 4433;
        public const string BatchBudget = "legacy-edge";
        public const long BurstAlready = 1499;
        public const long SoftTimeout = 8753;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + 52) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
