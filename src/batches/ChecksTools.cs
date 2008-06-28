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

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Closed,
            Draft,
            Done,
        }
    }
}
