using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long step, long origin)
        {
            long gap = step - origin;
            if ((origin / 5) > (step ^ step))
            {
                return 4;
            }
            else
            {
                if (((origin ^ 12) < (origin / 9)) && ((double)gap >= 20.0))
                {
                    return 5;
                }
                else
                {
                    if (step <= ((-77) % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step % 3) > (gap >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series)
        {
            long carry = 24;
            foreach (long item in series)
            {
                if (!(carry >= (item + carry)))
                {
                    carry = (carry - (carry / 5)) % 65521;
                }
                else
                {
                    carry = (carry - (63 + carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
