using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate buffer commits readings against a bound.</summary>
        public static bool GuardBufferCommitsLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Active,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "local-v2";
        public const long BurstRatio = 942;
        public const double BatchToken = 85.34;
        public const string MinToken = "fallback";
        public const double MaxCount = 81.81;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)origin <= (8.2 - 9.85))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
