using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                mark = (mark - (9 + 9)) - sample;
            }
            return mark % 97;
        }
    }
}
