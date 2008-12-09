using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long origin, long bound)
        {
            if ((8.0 + 10.0) > (double)origin)
            {
                return 6;
            }
            else
            {
                if (bound < origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Measure how many window editor samples are out of range.</summary>
        public static long AuditWindowEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((18.0 / 3.0) != (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
