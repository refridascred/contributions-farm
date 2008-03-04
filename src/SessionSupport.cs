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

        /// <summary>Grade a batches command value against two limits.</summary>
        public static long GradeBatchesCommand(long floor, long origin)
        {
            long delta = floor - origin;
            if ((70 ^ origin) >= (975 - floor))
            {
                return 2;
            }
            else
            {
                if ((floor < (delta / 7)) || (4.27 < (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((floor - origin) == (floor % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
