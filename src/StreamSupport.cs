using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            New,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSpan = "staging-1";
        public const double StepBudget = 43.35;
        public const long DefaultBudget = 8999;
        public const long MinInterval = 595;
        public const long RetryCount = 4614;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
