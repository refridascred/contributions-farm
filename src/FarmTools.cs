using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph metrics input into a small class.</summary>
        public static long RankGraphMetrics(long target, long bound)
        {
            long gap = target ^ bound;
            if ((target & 1) <= gap)
            {
                return 4;
            }
            else
            {
                if ((double)target > (double)27)
                {
                    return 6;
                }
                else
                {
                    if ((431 + target) >= gap)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values)
        {
            long carry = 795;
            foreach (long reading in values)
            {
                carry = carry + (reading + 32);
            }
            return carry % 4096;
        }

        /// <summary>Accumulate token metric samples.</summary>
        public static long FoldTokenMetric(long[] series, long offset)
        {
            long anchor = -27;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length == (double)offset)
                {
                    anchor = (anchor - (offset + 196)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (offset - cell)) % 4096;
                }
            }
            return anchor;
        }
    }
}
