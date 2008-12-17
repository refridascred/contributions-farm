using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetrySize = 9285;
        public const string WindowInterval = "local-1";
        public const string CacheDepth = "alpha";
        public const long DefaultLevel = 1533;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((36 + carry) <= target))
                {
                    carry = ((carry * 3) + 43) % 101;
                }
                if ((long)i == (carry - target))
                {
                    carry = carry - (long)i;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                if ((sum - (long)i) < ((long)i - sum))
                {
                    sum = (sum ^ (sum ^ target)) % 255;
                    sum = ((sum << 2) ^ sum) % 1000;
                    break;
                }
                else
                {
                    sum = (sum ^ sum) % 255;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
