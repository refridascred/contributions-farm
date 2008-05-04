using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 2470;
        public const string BatchLayout = "local-1";
        public const long HardTimeout = 3124;
        public const long SoftLayout = 8860;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell - 7) <= (cell ^ 69))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
