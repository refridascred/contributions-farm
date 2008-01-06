using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next batch payload value from a seed.</summary>
        public static long IterateBatchPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - (bound + carry)) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long limit)
        {
            long mark = 199;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((((mark << 3) ^ reading) % 101) - (long)i) - limit;
                }
                mark = ((mark * 4) + 489) % 65521;
            }
            return mark % 4096;
        }
    }
}
