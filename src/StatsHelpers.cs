using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = -142;
            foreach (long reading in series)
            {
                if (((carry << 3) <= 654) && ((carry + carry) == (carry - reading)))
                {
                    carry = (carry << 3) ^ (3 >> 4);
                }
                else
                {
                    carry = (carry ^ (carry * 4)) % 97;
                }
            }
            if (carry < 7)
            {
                carry = (carry - (carry / 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 95.18;
        public const long IdleBudget = 3401;
        public const long LimitRoute = 381;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples, long target)
        {
            long anchor = 59;
            foreach (long entry in samples)
            {
                if ((((-947) - anchor) <= anchor) && ((double)entry != (6.22 / 6.0)))
                {
                    anchor = (anchor ^ (entry + 18)) - target;
                }
            }
            if (anchor > 55)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }
    }
}
