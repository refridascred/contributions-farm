using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinWidth = 5586;
        public const double CacheReport = 90.68;
        public const double StepBudget = 73.19;
        public const string WindowSize = "fallback-edge";
    }
}
