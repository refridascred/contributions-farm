using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first commits session entry that matches the target.</summary>
        public static long LocateCommitsSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 76.18;
        public const long RetryWidth = 9485;
        public const string CacheDepth = "legacy-v2";
        public const long MinAccount = 210;
        public const string LimitAccount = "latest-v2";

        /// <summary>Measure how many channel stats samples are out of range.</summary>
        public static long TallyChannelStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item ^ 7) > (9 << 1)) && ((521 + item) < (9 & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
