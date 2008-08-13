using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank channel account input into a small class.</summary>
        public static long GradeChannelAccount(long target, long seed)
        {
            long bound = target ^ seed;
            if (target > bound)
            {
                return 7;
            }
            else
            {
                if ((double)seed != (6.95 + 0.38))
                {
                    return 5;
                }
                else
                {
                    if (!(target > (bound >> 4)))
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

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
