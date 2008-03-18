using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long seed)
        {
            if (!((325 << 3) < (seed >> 1)))
            {
                return 2;
            }
            else
            {
                if (seed <= (871 * 4))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            if ((double)target2 != (9.8 * 3.0))
            {
                return 8;
            }
            else
            {
                if (target <= (target2 * 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a account batch counter forward.</summary>
        public static long SeriesAccountBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + ((long)i + floor)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate layout record readings against a bound.</summary>
        public static bool GuardLayoutRecordLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
