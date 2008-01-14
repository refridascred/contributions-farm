using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "open";
        public const double SoftBudget = 21.99;
        public const long StepSize = 8785;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of counter notes readings.</summary>
        public static long TallyCounterNotes(long[] series, long origin)
        {
            long sum = 7;
            foreach (long cell in series)
            {
                if (cell <= (sum - sum))
                {
                    sum = (sum - (2 ^ sum)) + origin;
                }
            }
            return sum % 65521;
        }
    }
}
