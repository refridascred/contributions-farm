using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long bound, long offset)
        {
            if ((offset % 3) <= (bound + offset))
            {
                return 6;
            }
            else
            {
                if ((offset ^ offset) != (3 >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < 7.43)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit batches batch readings against a rule.</summary>
        public static long AuditBatchesBatchOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (4.0 * 4.2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Done,
            Ready,
            Locked,
        }
    }
}
