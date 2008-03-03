using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (!((34 - diff) >= limit))
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (5.17 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor <= (floor << 2)) || (floor < diff))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((408 + limit) != (floor - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values, long target)
        {
            long total = 87;
            foreach (long value in values)
            {
                if ((target + 831) >= 921)
                {
                    total = ((total ^ 11) % 255) + value;
                }
                else
                {
                    total = (total * 2) + (target >> 3);
                }
            }
            if (total < (-2))
            {
                total = (total ^ (target << 1)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Ready,
            Locked,
        }
    }
}
