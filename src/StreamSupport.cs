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

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long limit)
        {
            long state = 602;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state + (5 - limit)) - (long)i) - reading;
                }
                state = ((state * 3) + (limit * 3)) % 65521;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 3857;
        public const long MaxPayload = 6737;
        public const long LimitInterval = 4998;
        public const long MinPayload = 2667;
    }
}
