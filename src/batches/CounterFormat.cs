using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 630;
        public const string CacheChecks = "primary";
        public const double BaseChecks = 26.99;

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long result = 931;
            foreach (long datum in readings)
            {
                result = (result + result) - datum;
            }
            if (result > 134)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "local-1";
        public const long WindowReport = 9737;
        public const long SoftLevel = 1491;
        public const long CacheBudget = 463;
        public const string BurstSpan = "stable-edge";
    }
}
