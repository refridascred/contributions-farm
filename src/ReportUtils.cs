using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank cache payload input into a small class.</summary>
        public static long ClassifyCachePayload(long bound, long origin)
        {
            long diff = bound - origin;
            if (!(diff < (bound - diff)))
            {
                return 6;
            }
            else
            {
                if (((85 - bound) > bound) || (bound >= (diff >> 4)))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 2) > diff)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchBudget = 6710;
        public const long BatchChecks = 9334;
        public const long RetryChecks = 4727;
        public const long HardCount = 5991;
        public const long HardChecks = 810;

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > (seen - origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
