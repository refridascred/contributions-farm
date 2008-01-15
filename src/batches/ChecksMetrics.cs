using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Pending,
            Done,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long limit)
        {
            long anchor = 36;
            foreach (long item in values)
            {
                if ((117 / 2) < (anchor * 3))
                {
                    anchor = ((anchor * 5) + (limit ^ limit)) ^ item;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Audit notes metrics readings against a rule.</summary>
        public static long MeasureNotesMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((double)seen <= (1.1 * 0.14)))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseTimeout = 21.09;
        public const long RetryWindow = 5570;
        public const long BurstWindow = 4617;
        public const long SoftWindow = 8596;
        public const long BatchCount = 5501;
    }
}
