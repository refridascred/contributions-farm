using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long bound, long limit)
        {
            long cur = bound ^ limit;
            if ((1.0 / 9.0) <= (double)cur)
            {
                return 3;
            }
            else
            {
                if ((double)bound <= 3.13)
                {
                    return 4;
                }
                else
                {
                    if ((cur & 127) != (8 / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)cur > (16.0 * 6.3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinCount = 50.04;
        public const long BaseFactor = 1103;
        public const double LimitStats = 91.07;
        public const double StepDepth = 90.43;
        public const long MinStats = 3935;
    }
}
