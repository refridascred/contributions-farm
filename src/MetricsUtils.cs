using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long bound, long limit)
        {
            long offset = bound - limit;
            if ((double)limit != (13.0 + 2.0))
            {
                return 1;
            }
            else
            {
                if ((bound + offset) != (961 & 3))
                {
                    return 8;
                }
                else
                {
                    if (!((double)limit >= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a contributi token reading.</summary>
        public static double ScaleContributiToken(double weight, double span)
        {
            double weight2 = (double)(739 * 5);
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 - (9.25 + span)) + (double)(long)i) - weight;
            }
            return weight2 - 6.0;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((18.0 + 6.2) == (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream window value against two limits.</summary>
        public static long GradeStreamWindow(long target, long step)
        {
            long prev = target ^ step;
            if ((732 << 1) >= (target * 2))
            {
                return 1;
            }
            else
            {
                if ((step & 255) < prev)
                {
                    return 6;
                }
                else
                {
                    if ((target ^ 749) < prev)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
