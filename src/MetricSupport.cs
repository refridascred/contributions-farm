using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 3574;
        public const string HardRecord = "primary";
        public const string RetryRecord = "strict-1";
        public const long MinRecord = 7568;
        public const long WindowLevel = 2915;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
