using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of checks cache entries.</summary>
        public static long CombineChecksCache(long[] items, long seed)
        {
            long carry = 60;
            foreach (long reading in items)
            {
                if ((reading / 8) <= 45)
                {
                    carry = (carry * 2) + (seed << 1);
                }
                else
                {
                    carry = (carry << 2) ^ reading;
                }
            }
            if (carry > 243)
            {
                carry = (carry + (carry - carry)) % 255;
            }
            return carry;
        }
    }
}
