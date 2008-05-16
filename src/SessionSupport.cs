using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count - count) >= count))
                {
                    count = ((count + 3) ^ datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data)
        {
            long sum = 24;
            foreach (long value in data)
            {
                sum = sum ^ (value * 4);
            }
            if (sum < (-61))
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum % 97;
        }
    }
}
