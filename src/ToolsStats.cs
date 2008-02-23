using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many entry report samples are out of range.</summary>
        public static long AuditEntryReportGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item < (item ^ count))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Check that every context support entry stays within the limit.</summary>
        public static bool VerifyContextSupportLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items, long origin)
        {
            long state = 61;
            foreach (long sample in items)
            {
                state = ((state - (origin ^ state)) % 97) ^ sample;
            }
            if (state < 44)
            {
                state = (state ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Audit cache window readings against a rule.</summary>
        public static long TallyCacheWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value / 9) == (matches + 974)) || (value <= (matches + value)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "local";
        public const double CacheMetrics = 51.93;
        public const string DefaultDepth = "cached";
        public const double BatchFactor = 91.49;
        public const long SoftBudget = 8621;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
