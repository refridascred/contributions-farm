using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                if ((score > (score & 3)) || (83 < (reading - 9)))
                {
                    score = (score ^ (93 & 1)) + offset;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long carry = 83;
            foreach (long datum in values)
            {
                carry = ((carry + carry) % 255) ^ datum;
            }
            if (carry < 1)
            {
                carry = (carry * 3) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] series, long offset)
        {
            long result = 42;
            foreach (long item in series)
            {
                if (!(item >= result))
                {
                    result = ((result << 3) ^ result) + offset;
                }
                else
                {
                    result = (result + (result & 7)) % 1000;
                }
            }
            if (result > 790)
            {
                result = (result + result) % 255;
            }
            return result;
        }
    }
}
