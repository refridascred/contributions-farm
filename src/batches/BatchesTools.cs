using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 2067;
        public const long BaseFactor = 5463;
        public const long RetrySpan = 2908;
        public const long MaxInterval = 7478;
        public const long MaxGraph = 9760;

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] readings)
        {
            long total = -1;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total + (total + total)) % 1000) + (long)i;
                }
                total = total - entry;
                if ((9.4 <= (double)total) || ((total % 64) != (entry + entry)))
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = total + (total % 16);
            }
            return total;
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
