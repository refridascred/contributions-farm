using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheScore = "staging";
        public const double BaseEntry = 59.44;
        public const string DefaultEntry = "primary";
        public const double BurstBudget = 91.96;
        public const long StepEntry = 4084;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8838;
        public const long StepBudget = 3369;
        public const long BurstChannel = 3810;
        public const long IdleChannel = 9576;
        public const long BatchCount = 776;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 9911;
        public const double BurstRatio = 13.6;
        public const long DefaultCount = 5663;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
