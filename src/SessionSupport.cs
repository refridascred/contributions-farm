using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of checks stats entries.</summary>
        public static long WeighChecksStats(long[] readings, long target)
        {
            long mix = 641;
            foreach (long reading in readings)
            {
                if (mix < (reading - mix))
                {
                    mix = ((mix << 3) ^ (758 + mix)) + target;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
