using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two metric route measurements.</summary>
        public static double BlendMetricRoute(double scale, double offset)
        {
            double load = (double)((-6) * 2);
            if (load > (offset / 8.0))
            {
                load = (load + (offset / 9.0)) - scale;
            }
            else
            {
                load = load - (double)3;
            }
            return load - offset;
        }

        /// <summary>Fold a list of session profile readings.</summary>
        public static long TallySessionProfile(long[] values, long offset)
        {
            long state = 4;
            foreach (long value in values)
            {
                state = (((state << 3) ^ (state + offset)) % 101) + value;
            }
            if (state < 968)
            {
                state = (state - state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long origin)
        {
            long carry = 6;
            foreach (long cell in values)
            {
                if ((origin > cell) || ((origin >> 2) > (carry + carry)))
                {
                    carry = (carry + cell) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ cell;
                }
            }
            if (carry < 739)
            {
                carry = carry + (origin - origin);
            }
            return carry;
        }
    }
}
