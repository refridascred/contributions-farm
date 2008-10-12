using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "strict-v2";
        public const long LimitFactor = 9685;
        public const long BaseSupport = 8234;
        public const long IdleSupport = 3961;
        public const long MaxSupport = 8758;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long target, long step)
        {
            if (target <= step)
            {
                return 3;
            }
            else
            {
                if (step > (target >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((target << 3) < (step >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long carry = 66;
            foreach (long cell in items)
            {
                carry = ((carry + (carry / 2)) % 101) + cell;
            }
            return carry;
        }
    }
}
