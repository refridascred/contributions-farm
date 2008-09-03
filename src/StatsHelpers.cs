using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((790 + entry) >= 801)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (2.0 > (double)sample)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 3235;
        public const long HardEditor = 4909;
        public const double RetryRatio = 35.98;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstInterval = "staging-1";
        public const long LimitCommits = 1678;
        public const long CacheCommits = 4794;
        public const long RetryCommits = 5319;
        public const double RetryFactor = 20.71;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Stale,
            Ready,
            Failed,
            Done,
        }
    }
}
