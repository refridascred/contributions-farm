using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "open";
        public const long MaxSession = 4752;
        public const double DefaultSession = 66.3;

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels, long step)
        {
            long mark = 42;
            foreach (long item in levels)
            {
                if (((double)9 < (double)item) || ((mark ^ 0) == (item << 2)))
                {
                    mark = (((mark * 3) + (87 + item)) % 4096) - step;
                }
                else
                {
                    mark = mark ^ ((long)levels.Length * 2);
                }
            }
            return mark;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (step > (item << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Pending,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 2161;
        public const long BaseSpan = 3332;
        public const long HardTools = 5781;
    }
}
