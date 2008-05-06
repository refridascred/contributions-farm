using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up route entry samples.</summary>
        public static long CompareRouteEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                long count = step;
                if ((833 - step) <= (2 >> 3))
                {
                    mark = mark + (count * 2);
                }
                mark = (mark * 5) + (step + 7);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Find the first queue commits entry that matches the target.</summary>
        public static long FindQueueCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 9225;
        public const double SoftBudget = 46.06;
        public const long IdleSession = 1185;
        public const double BaseSession = 50.62;
        public const double SoftRatio = 22.96;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long offset)
        {
            if ((7.0 + 1.71) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)target > (3.0 - 8.0))
                {
                    return 6;
                }
                else
                {
                    if ((29 ^ 0) > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Locked,
            Queued,
            Done,
            Dropped,
        }
    }
}
