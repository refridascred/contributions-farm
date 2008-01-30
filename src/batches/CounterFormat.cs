using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell >= (seen - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "fallback-v2";
        public const long DefaultReport = 5042;
        public const double LimitCount = 42.98;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
