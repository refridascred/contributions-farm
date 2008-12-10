using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultFactor = "alpha-v2";
        public const double HardLevel = 78.65;
        public const string BatchRecord = "fallback";

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 38.37;
        public const long DefaultNotes = 9294;
        public const long RetryNotes = 4595;
        public const double MaxNotes = 48.5;
        public const long HardCount = 1366;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
