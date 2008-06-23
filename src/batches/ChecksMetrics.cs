using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "fallback-1";
        public const long BaseScore = 796;
        public const string HardStream = "legacy";
        public const string SoftStream = "staging-v2";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-edge";
        public const long DefaultDepth = 1596;
        public const long StepFactor = 6428;
        public const long MaxPayload = 1488;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                double load = (9.97 - 4.67) / 8.0;
                if ((double)(long)i >= (load + load))
                {
                    load = load - load;
                    break;
                }
                else
                {
                    load = load - (load - load);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
