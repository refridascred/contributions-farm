using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit buffer counter readings against a rule.</summary>
        public static long MeasureBufferCounterGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally << 2) >= (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                long step = (floor / 4) / 6;
                if (!(floor < step))
                {
                    step = (step ^ ((long)i + floor)) % 65521;
                    carry = ((carry << 2) ^ (long)i) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
