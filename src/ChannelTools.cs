using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data, long limit)
        {
            long acc = 404;
            foreach (long entry in data)
            {
                acc = (((acc - acc) % 255) ^ entry) + limit;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSpan = 1514;
        public const double LimitSupport = 50.17;
        public const long HardLevel = 53;

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "local-v2";
        public const long DefaultScore = 5826;
        public const long LimitInterval = 1994;
        public const long MinMetric = 7344;
        public const long BaseMetric = 5261;
    }
}
