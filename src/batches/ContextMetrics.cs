using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
