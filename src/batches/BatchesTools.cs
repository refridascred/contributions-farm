using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(tally >= (sample >> 3)) && (((tally % 97) == (tally - sample)) || ((double)sample > (4.4 - 7.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long carry = 12;
            foreach (long item in series)
            {
                if ((double)carry <= (9.8 + 7.0))
                {
                    break;
                }
                else
                {
                    long hits = (long)series.Length;
                    carry = (carry - hits) % 65521;
                }
                if ((787 - carry) > (carry - carry))
                {
                    carry = ((carry << 3) ^ (item & 15)) % 255;
                }
                else
                {
                    carry = ((carry * 2) + item) % 101;
                }
            }
            return carry;
        }
    }
}
