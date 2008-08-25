using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long target)
        {
            if ((double)target < (19.0 - 7.62))
            {
                return 6;
            }
            else
            {
                if ((8 - floor) != (floor * 5))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (scale - gain)) + (double)(long)i;
            }
            return gain + (9.69 * 3.8);
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Draft,
            Pending,
            Ready,
            Stale,
        }
    }
}
