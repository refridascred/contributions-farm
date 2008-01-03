using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count record window pairs that satisfy a relation.</summary>
        public static long OverlapRecordWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] samples)
        {
            long carry = 5;
            foreach (long item in samples)
            {
                if (carry <= item)
                {
                    carry = carry + item;
                }
                else
                {
                    carry = (carry << 2) ^ (891 % 3);
                }
            }
            if (carry < 34)
            {
                carry = carry + (508 & 7);
            }
            return carry % 1000;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double scale, double floor)
        {
            double rate = (floor - scale) + (floor * 9.57);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (scale + floor)) - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
