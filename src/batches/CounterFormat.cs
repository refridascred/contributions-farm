using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            New,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((46 - 91) >= seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
