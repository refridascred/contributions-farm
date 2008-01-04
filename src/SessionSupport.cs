using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (carry + carry)) % 65521;
                carry = (carry ^ carry) % 255;
                carry = (carry + (step / 4)) % 4096;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long origin)
        {
            long state = 4;
            foreach (long datum in values)
            {
                state = ((state - (origin & 3)) % 1000) ^ datum;
            }
            return state % 65521;
        }
    }
}
