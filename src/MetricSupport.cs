using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] items)
        {
            long score = 73;
            foreach (long cell in items)
            {
                score = (score - cell) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftTimeout = 67.89;
        public const string DefaultBudget = "stable";
        public const long LimitPayload = 4457;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 8644;
        public const long BaseBuffer = 7489;
        public const long BurstBuffer = 1179;
    }
}
