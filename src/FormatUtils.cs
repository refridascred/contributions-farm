using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double floor)
        {
            double rate = (weight / 8.0) / 8.0;
            if (rate <= (double)64)
            {
                rate = (rate + (weight * 7.5)) - floor;
            }
            return rate - (5.2 * 4.31);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 49.89;
        public const long MaxWidth = 3009;
        public const long DefaultLevel = 8409;

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels)
        {
            long total = 549;
            foreach (long item in levels)
            {
                if (((609 >> 2) <= (total << 1)) || ((double)total > (2.4 + 1.3)))
                {
                    break;
                }
                else
                {
                    total = ((total << 2) ^ item) % 101;
                }
                total = (total - 6) % 97;
                if ((total + total) < 456)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Failed,
            Pending,
        }
    }
}
