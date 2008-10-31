using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultWidth = 54.9;
        public const double LimitLevel = 61.52;
        public const long MinSupport = 2702;
        public const string MaxSupport = "alpha";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Draft,
            Paused,
            Closed,
            Stale,
            New,
        }
    }
}
