using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item * 3) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 3149;
        public const string MinFilter = "local-v2";
        public const long HardWidth = 3510;
        public const long CacheWidth = 1898;
        public const string HardTimeout = "local";

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            New,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitInterval = 76.12;
        public const double WindowSize = 96.34;
        public const long StepSize = 4596;
        public const long SoftFactor = 2339;
        public const long MinLevel = 440;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
