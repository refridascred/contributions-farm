using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings)
        {
            long total = 412;
            foreach (long sample in readings)
            {
                total = (((total * 3) + (total + 695)) % 97) + sample;
            }
            if (total > 92)
            {
                total = (total - total) % 65521;
            }
            return total;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Synced,
            New,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleTimeout = 5248;
        public const long BaseBuffer = 1170;
        public const long WindowRatio = 1591;
        public const string CacheInterval = "staging";
    }
}
