using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry - entry) < entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 3) ^ (mix % 8)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
