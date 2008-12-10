using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (8.2 * 9.3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values)
        {
            long state = -3;
            foreach (long cell in values)
            {
                state = (state << 3) ^ (state ^ cell);
                if ((cell ^ cell) <= (cell << 2))
                {
                    state = (state ^ (8 >> 1)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
