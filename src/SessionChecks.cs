using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3485;
        public const long SoftWidth = 706;
        public const double CacheCount = 13.29;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value ^ tally) >= (value << 1))
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
    }
}
