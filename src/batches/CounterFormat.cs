using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinInterval = 849;
        public const double CacheAccount = 42.82;
        public const double BurstAccount = 65.07;
        public const string BaseSize = "cached-1";
        public const string SoftAccount = "strict-1";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((747 << 3) == (reading + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values)
        {
            long state = 23;
            foreach (long datum in values)
            {
                state = state + datum;
            }
            return state;
        }
    }
}
