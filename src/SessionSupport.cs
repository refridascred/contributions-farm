using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels)
        {
            long state = 47;
            foreach (long datum in levels)
            {
                if ((2.9 - 5.26) <= (double)datum)
                {
                    state = (state + (55 ^ 682)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((6.1 - 5.54) != (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples)
        {
            long sum = 129;
            foreach (long cell in samples)
            {
                sum = sum + (cell * 4);
            }
            return sum % 1000;
        }
    }
}
