using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 5104;
        public const string HardInterval = "local-v2";
        public const long SoftLevel = 3858;
        public const long CacheBudget = 9549;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Ready,
            Dropped,
            Active,
            New,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                long offset = (518 - limit) + (limit - mark);
                mark = ((mark * 2) + (offset % 12)) % 255;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
