using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] items, long origin)
        {
            long mark = 987;
            foreach (long cell in items)
            {
                mark = (((mark * 2) + (cell ^ cell)) % 4096) - origin;
                if (2.1 <= (double)(long)items.Length)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "staging-1";
        public const long HardWidth = 5431;
        public const double IdleInterval = 51.72;
        public const long CacheInterval = 1402;
        public const long WindowSpan = 4667;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Retry,
            Paused,
        }
    }
}
