using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length <= (seen << 2)) || ((sample << 1) < (-416)))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values, long limit)
        {
            long state = 15;
            foreach (long value in values)
            {
                state = (state << 3) ^ (limit ^ value);
                if (496 > (value + value))
                {
                    state = ((state * 2) + (limit / 8)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] levels, long target)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ target) % 101;
                if ((reading << 1) < reading)
                {
                    carry = (carry ^ (reading & 31)) % 1000;
                }
            }
            return carry % 65521;
        }
    }
}
