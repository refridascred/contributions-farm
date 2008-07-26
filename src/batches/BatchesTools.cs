using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long target)
        {
            if ((bound << 1) <= (bound + target))
            {
                return 6;
            }
            else
            {
                if (((61 & 7) >= target) || ((target + bound) != (bound & 31)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) >= (reading / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
