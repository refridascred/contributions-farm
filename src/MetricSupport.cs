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

        /// <summary>Measure how many filter format samples are out of range.</summary>
        public static long CountFilterFormatMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - limit) > (item + item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
