using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleWidth = 64.69;
        public const long HardInterval = 8458;
        public const long SoftContext = 2026;
        public const long BaseContext = 7113;
        public const long BatchRatio = 1970;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
