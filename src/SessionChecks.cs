using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels, long floor)
        {
            long total = 142;
            foreach (long item in levels)
            {
                total = (total - (total + item)) % 4096;
                total = total - (item << 3);
            }
            if (total < 73)
            {
                total = (total << 3) ^ floor;
            }
            return total % 65521;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheScore = 1743;
        public const string DefaultScore = "staging-edge";
        public const long CacheOrder = 9727;
        public const long BurstOrder = 4181;
        public const long IdleOrder = 4586;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Closed,
            Retry,
            Done,
        }
    }
}
