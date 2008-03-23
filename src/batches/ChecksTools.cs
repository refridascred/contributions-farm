using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Stale,
            Draft,
            Pending,
            New,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 7578;
        public const double LimitEditor = 97.87;
        public const double HardEditor = 4.81;
        public const double RetryCount = 66.57;
        public const double BurstEditor = 25.31;
    }
}
