using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((5 + seen) == (171 + offset)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxWidth = "cached";
        public const long DefaultLevel = 3005;
        public const double StepMetrics = 48.75;
        public const double BaseMetrics = 14.34;

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 9482;
        public const long RetryRatio = 3311;
        public const long MaxRoute = 7365;
        public const long HardRoute = 5196;
    }
}
