using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit channel counter readings against a rule.</summary>
        public static long TallyChannelCounterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item > (14.0 * 15.0))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }
    }
}
