using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "fallback-edge";
        public const long BurstAlready = 3642;
        public const long LimitDepth = 3687;
        public const long BaseRatio = 8090;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double drift = (double)79 * 7.0;
            return ((drift - 14.0) + bias) + span;
        }
    }
}
