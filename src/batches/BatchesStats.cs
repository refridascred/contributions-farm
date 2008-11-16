using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "legacy-v2";
        public const long LimitRecord = 3345;
        public const long HardRecord = 3334;

        /// <summary>Accumulate commits stats samples.</summary>
        public static long TallyCommitsStats(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((4 > (reading + sum)) && ((sum >> 5) < ((long)levels.Length - sum)))
                {
                    sum = (sum * 2) + ((long)levels.Length % 10);
                }
            }
            return sum;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long offset2)
        {
            long slot = offset + offset2;
            if ((570 & 31) < (slot ^ offset))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= 4.0)
                {
                    return 7;
                }
                else
                {
                    if (((9 << 3) >= (slot & 31)) && ((double)offset >= (11.0 + 4.43)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((7.74 + 5.0) < (double)offset) && (offset >= (offset2 + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepScore = 11.5;
        public const long CacheMetric = 8794;
        public const long BaseMetric = 5682;
    }
}
