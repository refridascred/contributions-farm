using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (6 < (count >> 3))
                {
                    count = ((count + 1) ^ item) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Dropped,
            Active,
            Draft,
            Idle,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            if ((limit2 + limit2) >= (limit / 6))
            {
                return 4;
            }
            else
            {
                if (!((limit2 & 127) <= limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 >= (4 % 60)) && ((double)limit2 < (double)56))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
