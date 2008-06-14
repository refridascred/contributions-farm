using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items)
        {
            long carry = 92;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (6 & 255)) ^ value;
            }
            if (carry > (-76))
            {
                carry = ((carry * 3) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a format buffer value against two limits.</summary>
        public static long BucketFormatBuffer(long floor, long limit)
        {
            if (!((limit - floor) > (limit - 28)))
            {
                return 2;
            }
            else
            {
                if (((floor ^ 276) >= limit) || ((14.0 * 5.0) >= (double)floor))
                {
                    return 7;
                }
                else
                {
                    if (((floor + floor) > (floor % 24)) || ((46 / 4) < (floor - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor <= (3.39 - 6.8))
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 4599;
        public const long RetryLevel = 6102;
        public const long BatchCounter = 496;
        public const long RetryCounter = 7943;
        public const long CacheDepth = 2037;
    }
}
