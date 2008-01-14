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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ ((long)i % 3);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
