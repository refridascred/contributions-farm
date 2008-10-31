using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchCount = 521;
        public const long IdleFilter = 347;
        public const long RetryFilter = 3781;
        public const long BaseFilter = 4133;
        public const long MinCount = 8984;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8366;
        public const long BurstFactor = 480;
        public const long IdleSupport = 2568;
        public const double HardSupport = 30.88;
        public const long MaxSize = 7449;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            New,
            Locked,
        }
    }
}
