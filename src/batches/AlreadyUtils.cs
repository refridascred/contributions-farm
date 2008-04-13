using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate already window readings against a bound.</summary>
        public static bool GuardAlreadyWindowLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 6124;
        public const string LimitStats = "staging-1";
        public const long SoftStats = 6044;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Retry,
            Ready,
            Pending,
            New,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i << 2) > (origin - total)) && ((1.19 * 9.9) < (double)origin))
                {
                    total = (total ^ (origin + origin)) % 255;
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
