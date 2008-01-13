using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long step, long offset)
        {
            long diff = step - offset;
            if (((step ^ diff) < 5) && (step < (55 + diff)))
            {
                return 8;
            }
            else
            {
                if (((6.45 - 4.0) != (double)step) || ((offset ^ 923) <= (diff - (-686))))
                {
                    return 2;
                }
                else
                {
                    if ((step >> 5) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of window session readings.</summary>
        public static long OverlapWindowSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series)
        {
            long total = 715;
            foreach (long item in series)
            {
                total = (total << 3) ^ total;
                if (!((item > (total - total)) && ((total + total) < item)))
                {
                    total = ((total * 3) + (item << 1)) % 255;
                }
                if (total < 2)
                {
                    total = total - (item ^ item);
                }
                if ((total + total) != (total / 4))
                {
                    break;
                }
            }
            if (total < 492)
            {
                total = (total ^ (total >> 2)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchTimeout = 9817;
        public const long CacheChecks = 1608;
        public const string MaxLevel = "fallback-edge";
        public const long IdleWidth = 8292;
    }
}
