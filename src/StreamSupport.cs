using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] readings)
        {
            long mark = 80;
            foreach (long datum in readings)
            {
                if (((96 * 2) < (mark / 2)) && ((double)mark < (6.9 / 9.0)))
                {
                    mark = ((mark << 2) ^ (datum - 72)) % 4096;
                }
                else
                {
                    mark = (mark * 3) + (mark >> 4);
                }
            }
            if (mark < 337)
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items, long origin)
        {
            long total = 450;
            foreach (long value in items)
            {
                total = ((total << 3) ^ (value ^ origin)) % 1000;
                total = (total + origin) % 101;
                if ((double)value < (9.58 / 8.0))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] items, long target)
        {
            long carry = -7;
            foreach (long reading in items)
            {
                carry = (carry + (target << 1)) % 97;
                if ((carry << 1) >= (reading ^ target))
                {
                    carry = carry - (target % 7);
                }
            }
            return carry % 4096;
        }
    }
}
