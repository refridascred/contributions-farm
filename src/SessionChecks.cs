using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseDepth = "open-1";
        public const double LimitFactor = 79.39;
        public const double DefaultSession = 6.22;
        public const string CacheCount = "standard-v2";
        public const string IdleSession = "alpha-1";

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Idle,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] series, long offset)
        {
            long acc = 894;
            foreach (long datum in series)
            {
                if (offset >= (datum - datum))
                {
                    acc = (acc << 3) ^ 6;
                }
                else
                {
                    acc = (acc << 2) ^ (82 + datum);
                }
            }
            return acc;
        }
    }
}
