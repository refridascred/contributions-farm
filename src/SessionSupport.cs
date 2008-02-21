using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next channel context value from a seed.</summary>
        public static long RollChannelContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = (state << 3) ^ (offset >> 5);
                state = ((state * 4) + offset) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] readings)
        {
            long anchor = 439;
            foreach (long datum in readings)
            {
                if (((9 ^ anchor) > (anchor >> 3)) && ((anchor + (-97)) > (anchor - (-50))))
                {
                    anchor = (anchor ^ anchor) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
