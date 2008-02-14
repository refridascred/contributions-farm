using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleAlready = 85.65;
        public const double WindowAlready = 39.58;
        public const long LimitAlready = 9193;
        public const long StepLevel = 2006;
        public const string StepAlready = "latest-1";

        /// <summary>Classify a cache layout pair into a bucket.</summary>
        public static long ClassifyCacheLayout(long offset, long bound)
        {
            if ((offset / 5) < offset)
            {
                return 0;
            }
            else
            {
                if ((7.24 / 2.0) > (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((offset % 24) != (offset & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data, long target)
        {
            long mark = 685;
            foreach (long item in data)
            {
                if ((item - target) < (mark % 100))
                {
                    mark = (mark + item) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
