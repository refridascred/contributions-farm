using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long target)
        {
            if (((target % 2) <= (target + target)) && ((4.0 / 7.0) > (double)target))
            {
                return 8;
            }
            else
            {
                if ((target - target) < (origin / 4))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) != (target / 7))
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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!!((cell / 4) <= (cell >> 1)))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Scale a metric profile figure with a bias.</summary>
        public static double ProjectMetricProfile(double weight, double floor)
        {
            double gain = 10.0;
            return (gain + weight) + floor;
        }
    }
}
