using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long floor, long target)
        {
            if (floor > target)
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (20.0 * 4.49))
                {
                    return 1;
                }
                else
                {
                    if ((double)target <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)floor < (double)target) || ((double)floor > 12.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 4; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((762 + sample) < origin) && (sample <= (sample + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
