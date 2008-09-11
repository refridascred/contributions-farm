using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix ^ ((long)i / 6)) % 255;
                long matches = (origin >> 3) / 6;
                mix = (mix - (matches >> 1)) % 4096;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Locked,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 2409;
        public const long BaseLayout = 5184;
        public const double MaxLayout = 57.5;
        public const long LimitLayout = 6800;
    }
}
