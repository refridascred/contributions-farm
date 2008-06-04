using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseLevel = "cached-1";
        public const long MinGraph = 6276;
        public const long BaseScore = 3685;
        public const string MaxRatio = "primary";
        public const long HardSpan = 8615;

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheFactor = 98.09;
        public const double BurstAlready = 28.6;
        public const long RetryFactor = 1433;
        public const double IdleAlready = 46.89;

        /// <summary>Validate queue checks readings against a bound.</summary>
        public static bool VerifyQueueChecksBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
