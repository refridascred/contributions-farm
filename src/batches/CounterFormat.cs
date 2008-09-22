using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "staging";
        public const long HardStream = 297;
        public const double MinWidth = 43.72;
        public const long LimitStream = 7874;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (8 >= (limit + seen))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseScore = 42.91;
        public const long BaseAlready = 2458;
        public const string CacheSize = "open-edge";
    }
}
