using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultBudget = 791;
        public const long BatchSize = 2384;
        public const double StepChecks = 6.8;
        public const long BaseChecks = 5502;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 1036;
        public const long LimitLevel = 1472;
        public const long DefaultDepth = 4077;
        public const long LimitToken = 1346;
        public const long BurstBudget = 9037;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
