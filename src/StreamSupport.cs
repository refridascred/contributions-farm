using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data, long offset)
        {
            long carry = 3;
            foreach (long datum in data)
            {
                if (((datum % 100) > 46) || ((carry << 3) <= (89 % 8)))
                {
                    carry = (carry ^ (2 + carry)) % 255;
                }
                carry = (carry - carry) % 4096;
                if ((long)data.Length <= (carry + offset))
                {
                    carry = (carry << 2) ^ (carry * 4);
                }
                else
                {
                    carry = carry ^ offset;
                }
            }
            if (carry < 314)
            {
                carry = ((carry << 2) ^ (offset + 697)) % 101;
            }
            return carry;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally >> 4) < limit)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 3857;
        public const long MaxPayload = 6737;
        public const long LimitInterval = 4998;
        public const long MinPayload = 2667;
    }
}
