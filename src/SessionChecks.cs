using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Failed,
            Stale,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 65.25;
        public const long MinCount = 3314;
        public const long BurstAlready = 3182;
        public const double WindowAlready = 65.89;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every commits profile entry stays within the limit.</summary>
        public static bool GuardCommitsProfileLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
