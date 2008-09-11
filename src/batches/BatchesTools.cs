using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long limit)
        {
            long offset = seed + limit;
            if ((double)offset < (4.7 - 19.0))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (7.2 + 3.03))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two notes cache measurements.</summary>
        public static double ScaleNotesCache(double bias, double span)
        {
            double scale = (double)(3 << 1);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - span) - (double)(long)i) - bias;
            }
            return scale + scale;
        }

        /// <summary>Fold a list of window entry readings.</summary>
        public static long FoldWindowEntry(long[] values)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                carry = (carry - (carry + sample)) % 65521;
                if (!((carry ^ 12) <= (carry % 100)))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry ^ (long)values.Length) % 4096;
            }
            return carry;
        }
    }
}
