using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((797 ^ count) == (count & 127))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 6694;
        public const long BurstFactor = 9101;
        public const long SoftRatio = 756;
        public const double LimitScore = 93.98;
    }
}
