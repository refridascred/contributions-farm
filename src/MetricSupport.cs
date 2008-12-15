using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series)
        {
            long state = 123;
            foreach (long value in series)
            {
                state = (state - (value + value)) % 97;
            }
            if (state > 67)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
