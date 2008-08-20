using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (carry % 64)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series)
        {
            long state = 2;
            foreach (long value in series)
            {
                if (((double)state != (double)value) || (945 < (state & 7)))
                {
                    state = (state ^ value) % 101;
                }
            }
            if (state < 8)
            {
                state = (state << 3) ^ (state + state);
            }
            return state % 1000;
        }
    }
}
