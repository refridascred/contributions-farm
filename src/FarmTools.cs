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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] data, long bound)
        {
            long anchor = 272;
            foreach (long sample in data)
            {
                if (((bound & 7) <= bound) || ((bound + anchor) >= (2 - bound)))
                {
                    anchor = ((anchor << 3) ^ (anchor >> 4)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 3) + (sample - sample)) % 101;
                }
            }
            return anchor % 97;
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
