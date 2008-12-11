using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSize = 490;
        public const long IdleCache = 5122;
        public const long MaxCache = 8658;
        public const long StepLevel = 8765;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Closed,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((state * 2) <= (bound << 3)))
                {
                    state = (state - (state << 3)) % 101;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
