using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryFactor = 14.54;
        public const double MinRecord = 44.83;
        public const long MaxRecord = 4397;
        public const double HardRecord = 64.45;
        public const string SoftRecord = "staging-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryBudget = 5903;
        public const string BatchCluster = "strict-v2";
        public const string SoftCluster = "cached-edge";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)step != (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
