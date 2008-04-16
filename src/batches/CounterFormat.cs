using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((15.0 - 6.6) >= (double)origin2)
            {
                return 1;
            }
            else
            {
                if ((5.85 - 2.44) < (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((6.0 / 4.0) < (double)origin2) || ((9.0 - 8.53) == (double)span))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin2 + 7) >= (origin + span))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
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
