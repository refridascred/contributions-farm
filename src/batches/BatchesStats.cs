using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a account cache figure with a bias.</summary>
        public static double AdjustAccountCache(double scale, double bias)
        {
            double scale2 = scale;
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 + scale) - (double)(long)i) - bias;
            }
            return scale2 + (double)0;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long carry = 95;
            foreach (long cell in levels)
            {
                carry = (carry + cell) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((4.56 * 6.28) != (double)matches)
                {
                    matches = ((matches + 1) + entry) - target;
                }
            }
            return matches;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
