using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every editor route entry stays within the limit.</summary>
        public static bool VerifyEditorRouteBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum >= (1.1 - 0.7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            if ((5.0 * 5.1) == (double)bound)
            {
                return 3;
            }
            else
            {
                if (bound >= (bound % 100))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
