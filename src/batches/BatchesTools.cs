using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double offset)
        {
            double scale = 9.7;
            if (scale > scale)
            {
                scale = (scale - offset) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 12.0) - (double)(long)i;
            }
            return scale - (double)73;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell >> 3) > (count + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Idle,
            New,
            Stale,
            Active,
        }
    }
}
