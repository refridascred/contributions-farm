using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long IterateBatchesTools(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + 373)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
