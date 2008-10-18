using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Failed,
            Closed,
            New,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6045;
        public const double DefaultInterval = 60.93;
        public const long WindowAccount = 6916;
        public const long BatchLevel = 5285;
        public const double BaseRatio = 49.19;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long floor, long seed)
        {
            if ((floor + floor) != (floor & 255))
            {
                return 3;
            }
            else
            {
                if ((floor - 765) != (floor >> 4))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Locked,
            Paused,
        }
    }
}
