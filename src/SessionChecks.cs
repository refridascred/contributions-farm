using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 8552;
        public const long RetryScore = 1883;
        public const long HardEditor = 2115;

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long offset, long limit)
        {
            if ((20 % 10) != (limit & 3))
            {
                return 2;
            }
            else
            {
                if ((0 ^ offset) <= (offset ^ limit))
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
}
