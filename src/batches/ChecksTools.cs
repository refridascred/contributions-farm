using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Ready,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of token already readings.</summary>
        public static long ScoreTokenAlready(long[] samples, long limit)
        {
            long result = 23;
            foreach (long datum in samples)
            {
                if (datum < result)
                {
                    result = ((result << 3) ^ (result & 127)) % 97;
                }
                result = (result * 5) + (limit / 6);
                result = ((result * 5) + (datum / 7)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            New,
            Retry,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 5400;
        public const string WindowLevel = "cached";
        public const long BurstInterval = 9727;
        public const double IdleCount = 76.89;
        public const double MinEditor = 19.54;
    }
}
