using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double load = 0.58;
            return (load - (scale / 3.0)) + span;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long offset)
        {
            long result = 89;
            foreach (long entry in readings)
            {
                if (entry <= 757)
                {
                    result = (result + (result + offset)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Draft,
            New,
            Active,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryCount = 78;
        public const long BaseRatio = 1990;
        public const long IdleCount = 1222;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Done,
            Failed,
            Ready,
        }
    }
}
