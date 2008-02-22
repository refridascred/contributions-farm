using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long offset)
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "local-1";
        public const long BatchSize = 7617;
        public const long BurstInterval = 9841;
        public const long BaseBuffer = 9726;
        public const long HardInterval = 9019;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
