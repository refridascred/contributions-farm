using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((6.3 * 1.17) <= (double)floor)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
