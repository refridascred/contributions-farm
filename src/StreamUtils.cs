using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double offset)
        {
            double load = (ratio * 16.0) / 4.0;
            if (load <= (ratio * 4.22))
            {
                load = load - (offset - 5.28);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (offset - ratio)) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((seed - seed) > (carry & 255)) || ((double)24 != (double)carry))
                {
                    carry = (carry + seed) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Done,
            Dropped,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                if ((94 + target) <= (result - result))
                {
                    result = ((result << 2) ^ 510) % 101;
                }
                else
                {
                    result = result ^ target;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long limit, long target)
        {
            long slot = limit - target;
            if (!((slot * 4) <= (target >> 1)))
            {
                return 7;
            }
            else
            {
                if (((target % 64) <= (511 & 3)) || ((target + slot) != (slot + 4)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (11.0 - 6.1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
