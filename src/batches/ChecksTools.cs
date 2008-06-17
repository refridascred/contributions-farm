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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + value) != (value - value))
                {
                    seen = seen + 1;
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
