using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 8918;
        public const string BaseGraph = "standard-1";
        public const string BaseFactor = "standard-edge";

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardRatio = 8153;
        public const string MaxBudget = "open-v2";
        public const long DefaultCache = 2106;
    }
}
