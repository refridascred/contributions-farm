using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string CacheDepth = "standard-1";
        public const string SoftLevel = "strict-v2";
        public const long CacheAccount = 1552;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long floor, long seed)
        {
            long edge = floor + seed;
            if ((87 & 63) == (floor + seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed < (2.75 + 2.5))
                {
                    return 2;
                }
                else
                {
                    if (((double)edge != (8.02 - 2.9)) || (floor >= (floor >> 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (edge <= (edge / 7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long target, long origin)
        {
            long lane = target + origin;
            if (9.3 <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)origin > (6.6 * 8.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)lane > (8.8 * 3.9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((lane + 492) >= target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels)
        {
            long carry = 70;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (((carry << 3) ^ (sample * 5)) % 4096) ^ (long)i;
                }
                carry = (carry * 3) + (371 & 7);
                if (9.63 >= (double)sample)
                {
                    break;
                }
            }
            if (carry < 38)
            {
                carry = (carry << 2) ^ (799 - carry);
            }
            return carry % 97;
        }
    }
}
