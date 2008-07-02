using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double bias2 = 9.0 * 4.4;
            if (bias2 > (double)1)
            {
                bias2 = (bias2 - bias) - gain;
            }
            return bias2 + bias2;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((7 % 5) < (target ^ target))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "primary-v2";
        public const double DefaultRatio = 90.96;
        public const long IdleSize = 9301;
        public const long CacheProfile = 4925;
        public const long BaseDepth = 6266;

        /// <summary>Count the already graph entries that pass the check.</summary>
        public static long TallyAlreadyGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((5.84 + 6.0) != (double)tally))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (1.0 > (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed2 * 4) < (seed2 - diff))
                {
                    return 6;
                }
                else
                {
                    if (!((916 - diff) != (seed + seed2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed > (double)63)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
