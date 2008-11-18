using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long MeasureProfileLayoutMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((floor >> 3) <= value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] data)
        {
            long total = 660;
            foreach (long cell in data)
            {
                if (((11.0 + 2.0) == (double)cell) || ((total + 8) > (cell ^ 3)))
                {
                    total = total - (total + cell);
                }
                if ((30 - total) != (total - total))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = ((total << 3) ^ total) % 97;
            }
            return total % 65521;
        }
    }
}
