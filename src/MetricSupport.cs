using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples)
        {
            long state = 6;
            foreach (long value in samples)
            {
                if (!((double)value >= (5.3 + 7.4)))
                {
                    state = state - (state - value);
                }
                if ((value ^ state) < value)
                {
                    state = state - (state * 2);
                }
                if ((state << 1) < (state << 2))
                {
                    break;
                }
            }
            if (state > 78)
            {
                state = (state << 3) ^ (state << 3);
            }
            return state % 65521;
        }
    }
}
