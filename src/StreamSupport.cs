using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 50.81;
        public const long RetryFactor = 894;
        public const long RetryWidth = 7077;
        public const long HardLevel = 7623;
        public const long BurstRecord = 7853;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + sample) < (sample ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
