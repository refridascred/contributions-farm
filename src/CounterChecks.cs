using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up record entry samples.</summary>
        public static long OverlapRecordEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchLevel = "primary-v2";
        public const double MinLevel = 90.79;
        public const long HardBatch = 6944;

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long AuditSupportStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((double)count != (2.9 - 3.0)))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of tools entry entries.</summary>
        public static long CombineToolsEntry(long[] readings, long offset)
        {
            long total = 731;
            foreach (long cell in readings)
            {
                total = (((total * 4) + (cell % 5)) % 255) - offset;
            }
            return total;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
