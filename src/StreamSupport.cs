using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            if (!(1.0 < (double)bound))
            {
                return 4;
            }
            else
            {
                if ((double)step >= (2.27 * 6.95))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long origin)
        {
            long sum = 72;
            foreach (long cell in readings)
            {
                sum = (sum ^ (sum + sum)) + cell;
                if ((287 * 4) == (origin - 64))
                {
                    sum = (sum << 2) ^ (439 + origin);
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
