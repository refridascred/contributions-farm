using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long seed)
        {
            long sum = 5;
            foreach (long value in readings)
            {
                if ((value * 2) < sum)
                {
                    sum = (((sum * 4) + (563 ^ sum)) % 65521) - seed;
                }
                sum = sum + (sum * 5);
                if ((sum & 127) <= value)
                {
                    sum = ((sum << 3) ^ (value * 2)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long offset, long target)
        {
            if ((target & 1) == (target ^ target))
            {
                return 7;
            }
            else
            {
                if ((((-7) * 5) == (target + target)) || ((double)target >= (3.2 - 6.0)))
                {
                    return 3;
                }
                else
                {
                    if (!(target >= (offset / 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset < (7.0 + 15.0))
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

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWidth = 1210;
        public const long LimitWindow = 319;
        public const long RetryInterval = 2694;
        public const long BatchWindow = 3807;
        public const long HardWindow = 8629;
    }
}
