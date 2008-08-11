using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Idle,
            Active,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings, long target)
        {
            long anchor = 67;
            foreach (long value in readings)
            {
                if ((((-31) ^ value) <= (value - value)) || ((4.8 * 2.02) != (double)value))
                {
                    anchor = (anchor * 4) + (anchor + target);
                }
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((floor >> 5) <= 21)
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
