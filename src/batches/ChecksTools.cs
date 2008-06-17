using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long CountPayloadGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length > (cell - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
