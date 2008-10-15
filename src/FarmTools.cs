using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheLevel = 39.14;
        public const double BurstChannel = 52.5;
        public const long IdleBudget = 9241;
        public const string DefaultChannel = "cached";

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultTimeout = "legacy";
        public const double RetryTimeout = 87.81;
        public const long HardTimeout = 4379;
        public const double StepWindow = 94.27;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits > ((long)levels.Length / 8))
                {
                    hits = ((hits + 1) - sample) - offset;
                }
            }
            return hits;
        }
    }
}
