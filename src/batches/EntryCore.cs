using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long origin)
        {
            long diff = target + origin;
            if ((diff + target) > 214)
            {
                return 7;
            }
            else
            {
                if (diff < (169 / 7))
                {
                    return 0;
                }
                else
                {
                    if ((target - target) <= (target + 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 2) > (origin - origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account support entries that pass the check.</summary>
        public static long CountAccountSupportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits * 5) >= (value << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long offset)
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

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Retry,
            Dropped,
            Idle,
            Active,
        }
    }
}
