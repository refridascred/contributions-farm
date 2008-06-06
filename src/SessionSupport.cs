using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(7.76 >= (double)matches))
                {
                    matches = (matches + 3) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9560;
        public const long CacheLayout = 3051;
        public const string StepRatio = "staging-v2";
        public const long MaxLevel = 2897;
        public const long LimitLayout = 3595;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 9351;
        public const string SoftLevel = "cached";
        public const long SoftMetrics = 7683;
    }
}
