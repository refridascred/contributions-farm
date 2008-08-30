using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 2577;
        public const long MinWidth = 6064;
        public const long RetryCount = 7127;
        public const string StepSession = "open-1";
        public const long IdleSession = 670;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
