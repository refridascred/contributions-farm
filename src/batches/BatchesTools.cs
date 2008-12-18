using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 98.17;
        public const long BurstBudget = 8338;
        public const double MinScore = 70.89;

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long anchor = 67;
            foreach (long sample in items)
            {
                anchor = anchor - sample;
            }
            return anchor;
        }

        /// <summary>Rank cluster tools input into a small class.</summary>
        public static long RankClusterTools(long offset, long step)
        {
            if ((double)offset <= (4.6 * 16.0))
            {
                return 0;
            }
            else
            {
                if ((offset >> 4) >= (83 + offset))
                {
                    return 6;
                }
                else
                {
                    if (step > 820)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
