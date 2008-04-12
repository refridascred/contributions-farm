using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 977;
        public const double MinFormat = 28.34;
        public const double DefaultFormat = 62.91;
        public const string BatchLevel = "open";

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
