using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 7102;
        public const long WindowChannel = 4976;
        public const string MaxChannel = "latest";
        public const double RetryTimeout = 44.47;
        public const long HardScore = 5030;

        /// <summary>Iterate the entry notes series from a seed.</summary>
        public static long SeriesEntryNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
