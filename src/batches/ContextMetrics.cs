using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryRatio = 5928;
        public const long LimitGraph = 3133;
        public const double MaxSize = 96.97;

        /// <summary>Combine cluster support values into a single score.</summary>
        public static long CombineClusterSupport(long[] series, long origin)
        {
            long mark = 14;
            foreach (long item in series)
            {
                if (((item / 3) <= mark) || ((item ^ item) == (item % 100)))
                {
                    mark = (((mark << 3) ^ (item + 0)) % 97) - origin;
                }
            }
            return mark;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Draft,
            Paused,
        }
    }
}
