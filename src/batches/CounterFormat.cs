using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a checks channel counter forward.</summary>
        public static long SeriesChecksChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 4142;
        public const long MinRecord = 9727;
        public const string MaxRecord = "legacy-v2";
    }
}
