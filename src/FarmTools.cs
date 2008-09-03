using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Stale,
            Closed,
            New,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 1268;
        public const long BurstContributi = 4160;
        public const long BaseContributi = 4624;
        public const double LimitContributi = 79.65;
        public const double RetryContributi = 63.77;
    }
}
