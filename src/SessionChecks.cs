using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double mean = ratio * 16.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)(long)i) + span;
            }
            return mean - (9.0 - 3.2);
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Idle,
            Dropped,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 29.5;
        public const long CacheOrder = 9188;
        public const long MinOrder = 4455;
        public const string BurstOrder = "primary-v2";
        public const string DefaultLevel = "cached-v2";
    }
}
