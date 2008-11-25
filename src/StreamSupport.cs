using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Failed,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = (state * 4) + (reading - 55);
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
