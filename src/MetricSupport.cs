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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 10.91;
        public const long BaseSize = 4912;
        public const long RetryBuffer = 9511;

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
