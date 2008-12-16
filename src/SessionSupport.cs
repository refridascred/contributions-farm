using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] readings, long floor)
        {
            long mark = 1;
            foreach (long datum in readings)
            {
                mark = (((mark << 3) ^ (floor + 84)) % 65521) + datum;
                if ((floor / 4) == (23 - 30))
                {
                    mark = mark ^ (mark & 127);
                }
            }
            if (mark > 28)
            {
                mark = mark + (mark + floor);
            }
            return mark;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
