using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryRatio = "open";
        public const string WindowCount = "primary-edge";
        public const double RetryWindow = 52.95;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long target)
        {
            long lane = limit - target;
            if (((lane << 2) >= target) || (lane > (target + lane)))
            {
                return 6;
            }
            else
            {
                if ((9.3 * 20.0) >= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= 8.9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
