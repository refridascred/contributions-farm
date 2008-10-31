using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if (((target + carry) <= (target - carry)) && ((13.0 / 7.0) <= (double)target))
                {
                    carry = (carry - ((long)i + 500)) % 255;
                }
                else
                {
                    carry = (carry + (target + 389)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                if (((double)reading <= (3.2 + 18.0)) && ((reading % 16) > (676 + reading)))
                {
                    state = ((state * 2) + (long)readings.Length) % 255;
                }
            }
            return state;
        }
    }
}
