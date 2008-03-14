using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)bound != (double)tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = carry + carry;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long result = -2;
            foreach (long entry in items)
            {
                result = result ^ (result & 127);
                if ((entry & 1) >= (entry + result))
                {
                    result = (result + 781) % 4096;
                }
            }
            if (result > 6)
            {
                result = result - (result + 3);
            }
            return result;
        }
    }
}
