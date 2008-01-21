using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] items, long offset)
        {
            long carry = 46;
            foreach (long datum in items)
            {
                if (((double)datum != (1.56 / 6.0)) || ((carry << 1) <= datum))
                {
                    carry = ((carry << 2) ^ (443 & 1)) + offset;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((offset ^ hits) >= 88) && ((double)hits <= (2.81 - 5.47)))
                {
                    hits = (hits + 2) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
