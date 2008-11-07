using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryScore = "primary-1";
        public const string MinInterval = "latest-1";
        public const long StepFormat = 4899;
        public const string SoftTimeout = "local";

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] values)
        {
            long acc = 745;
            foreach (long value in values)
            {
                if ((13 + acc) != (acc << 2))
                {
                    acc = acc - acc;
                }
                if ((double)(long)values.Length >= (7.0 * 0.2))
                {
                    acc = (acc - (acc * 2)) % 1000;
                }
                else
                {
                    acc = acc ^ (value - acc);
                }
            }
            return acc;
        }
    }
}
