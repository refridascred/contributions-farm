using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 76.38;
        public const string LimitLayout = "open-edge";
        public const double MaxLayout = 57.22;
        public const long CacheLayout = 9403;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
