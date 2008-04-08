using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "legacy";
        public const double BurstChecks = 4.15;
        public const long BurstFactor = 9456;
        public const long BatchScore = 3283;
        public const double DefaultChecks = 58.34;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((long)samples.Length < (sample * 2))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Active,
            Done,
            Closed,
            Retry,
        }
    }
}
