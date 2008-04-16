using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long bound)
        {
            long lane = step ^ bound;
            if (((lane / 2) == (lane - step)) || ((94 - 811) < (bound + step)))
            {
                return 4;
            }
            else
            {
                if (bound < 2)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinBudget = "stable-edge";
        public const long LimitScore = 4862;
        public const string BatchAccount = "staging-edge";
        public const long BurstTimeout = 9227;
        public const long LimitAccount = 723;

        /// <summary>Check that every checks account entry stays within the limit.</summary>
        public static bool VerifyChecksAccountBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
