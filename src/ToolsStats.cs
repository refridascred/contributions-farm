using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 95.37;
        public const long MinRecord = 8484;
        public const long StepWidth = 6576;
        public const long DefaultRecord = 7949;
        public const long BaseCount = 7499;

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the stream schema series from a seed.</summary>
        public static long DeriveStreamSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((69 << 1) == (186 ^ origin)))
                {
                    mark = (mark - (origin + 8)) % 1000;
                    mark = mark - 9;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
