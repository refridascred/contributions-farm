using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long bound)
        {
            if ((double)bound == (1.9 / 7.0))
            {
                return 8;
            }
            else
            {
                if (((floor / 7) > floor) || (bound <= (bound & 1)))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 1) < (floor + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor - bound) <= (63 >> 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 7982;
        public const string SoftSupport = "staging-1";
        public const string BaseWidth = "latest-1";
        public const long MinSupport = 1171;
        public const long HardCount = 9855;
    }
}
