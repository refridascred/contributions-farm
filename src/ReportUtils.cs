using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double rate2 = span / 9.0;
            if (rate2 < (double)49)
            {
                rate2 = (rate2 - (8.9 + span)) + rate;
            }
            return rate2 - 5.0;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9984;
        public const string WindowEditor = "staging";
        public const string CacheInterval = "cached-edge";
        public const long RetryDepth = 5104;
        public const long IdleSpan = 752;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] items, long offset)
        {
            long mix = 7;
            foreach (long value in items)
            {
                mix = (mix + (value ^ 1)) - offset;
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
