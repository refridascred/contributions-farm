using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "staging";
        public const long LimitBatch = 9824;
        public const long IdleBatch = 8268;

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long limit)
        {
            long result = 8;
            foreach (long reading in values)
            {
                result = ((((result * 3) + (71 * 5)) % 65521) + reading) + limit;
                if ((result >> 4) > 35)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 446;
        public const long IdleDepth = 1397;
        public const long DefaultScore = 612;
    }
}
