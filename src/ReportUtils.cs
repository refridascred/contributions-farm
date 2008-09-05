using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long bound)
        {
            if ((origin % 7) != (origin - origin))
            {
                return 6;
            }
            else
            {
                if ((2.98 - 5.0) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "cached-edge";
        public const double StepRatio = 35.28;
        public const long RetryChannel = 34;
    }
}
