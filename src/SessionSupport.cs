using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry * 4) + carry) - (long)i;
                    carry = (carry * 2) + sample;
                }
                carry = (carry * 3) + (sample & 3);
            }
            if (carry > 502)
            {
                carry = carry - (823 + carry);
            }
            return carry;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((8.85 - 9.0) <= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
