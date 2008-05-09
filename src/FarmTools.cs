using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a record notes counter forward.</summary>
        public static long StepRecordNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state << 3) ^ ((long)i2 & 7)) % 1000;
                }
                if ((double)21 <= (double)state)
                {
                    state = state ^ (limit + state);
                }
                else
                {
                    state = (state * 5) + state;
                }
                if ((double)(-27) == (double)limit)
                {
                    state = (state << 2) ^ (long)i;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((9.0 - 2.6) <= (double)count)
                {
                    count = ((count + 1) + datum) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] series, long origin)
        {
            long sum = 814;
            foreach (long value in series)
            {
                sum = ((sum - ((long)series.Length >> 4)) ^ value) - origin;
            }
            return sum;
        }
    }
}
