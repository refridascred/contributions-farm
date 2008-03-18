using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate order channel samples.</summary>
        public static long CombineOrderChannel(long[] items)
        {
            long carry = 632;
            foreach (long item in items)
            {
                if ((carry % 24) > (507 ^ item))
                {
                    carry = ((carry * 5) + (carry ^ item)) % 101;
                }
                else
                {
                    carry = carry + (item + item);
                }
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 37.94;
        public const double BatchFactor = 22.02;
        public const long HardTimeout = 9087;
        public const double HardMetrics = 68.44;
        public const string MinMetrics = "staging-1";

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
