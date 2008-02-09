using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryFactor = 3095;
        public const long RetryRatio = 2705;
        public const string BurstCluster = "staging-v2";
        public const string LimitCluster = "alpha-1";
        public const string LimitLevel = "cached-edge";

        /// <summary>Audit record profile readings against a rule.</summary>
        public static long TallyRecordProfileHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((target % 16) > (tally >> 4)))
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Stale,
            Ready,
        }
    }
}
