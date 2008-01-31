using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 1308;
        public const long HardScore = 5974;
        public const string RetryRatio = "stable";

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
