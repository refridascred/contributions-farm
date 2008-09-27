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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
