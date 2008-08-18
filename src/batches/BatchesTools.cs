using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long floor, long target)
        {
            long next = floor - target;
            if ((12.0 - 4.5) >= (double)next)
            {
                return 3;
            }
            else
            {
                if (((next % 16) <= target) && ((double)floor != (6.74 * 3.6)))
                {
                    return 5;
                }
                else
                {
                    if (((3 % 64) >= (floor ^ 23)) && (floor >= (target - next)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor * 3) != (target / 6)) && ((double)next > (8.5 - 5.93)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double rate, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (rate * 18.0)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Locked,
            Closed,
            Pending,
        }
    }
}
