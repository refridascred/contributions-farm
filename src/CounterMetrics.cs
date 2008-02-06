using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples)
        {
            long state = 0;
            foreach (long reading in samples)
            {
                if (state > (reading - state))
                {
                    state = state - ((-6) * 2);
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ entry) <= 50)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count ^ cell) < 534)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Done,
            Locked,
            Active,
            Idle,
        }
    }
}
