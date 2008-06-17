using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public double Token { get; set; }
        }
    }
}
