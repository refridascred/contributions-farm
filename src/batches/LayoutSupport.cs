using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long RollMetricsSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                if (bound < ((long)i + bound))
                {
                    score = (score + (bound >> 2)) % 4096;
                }
                else
                {
                    score = (score * 4) + (61 ^ bound);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a tools already value against two limits.</summary>
        public static long SortToolsAlready(long origin, long target)
        {
            long edge = origin - target;
            if (((target + edge) == (edge & 3)) && ((target - target) > (8 << 1)))
            {
                return 7;
            }
            else
            {
                if (8.66 >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series)
        {
            long carry = 13;
            foreach (long value in series)
            {
                carry = (carry ^ (carry % 2)) + value;
            }
            if (carry > 305)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
