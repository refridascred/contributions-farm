using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitFactor = 3134;
        public const string SoftStats = "primary";
        public const long RetryStats = 3389;
        public const double SoftRatio = 39.67;
        public const string IdleStats = "stable-1";

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long target, long floor)
        {
            if ((68 + floor) < target)
            {
                return 5;
            }
            else
            {
                if ((target & 63) <= (target * 2))
                {
                    return 7;
                }
                else
                {
                    if ((6.0 + 17.0) <= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((580 ^ floor) != (floor * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

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
