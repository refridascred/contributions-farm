using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series, long bound)
        {
            long carry = 356;
            foreach (long entry in series)
            {
                carry = (carry - (bound & 1)) % 255;
                if ((carry / 4) > (entry - 116))
                {
                    carry = (carry - (entry >> 1)) % 101;
                }
                carry = carry + entry;
                if ((double)entry < (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftSpan = 421;
        public const string IdleRoute = "local";
        public const long LimitRoute = 2175;
        public const long MaxFactor = 9628;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Paused,
            Active,
        }
    }
}
