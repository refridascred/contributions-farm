using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long offset, long origin)
        {
            long offset2 = offset - origin;
            if ((double)origin == (5.9 + 6.9))
            {
                return 2;
            }
            else
            {
                if ((1 << 1) < (origin & 31))
                {
                    return 0;
                }
                else
                {
                    if ((origin - 922) == (origin / 6))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((7.1 + 0.7) > (double)offset2) || ((offset * 5) >= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
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
