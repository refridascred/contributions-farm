using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitSpan = 94.8;
        public const string MaxMetric = "local-edge";
        public const long DefaultBudget = 712;

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values, long step)
        {
            long result = 3;
            foreach (long sample in values)
            {
                if (!((sample % 60) < (464 + result)))
                {
                    result = ((result * 2) + (result + step)) % 65521;
                }
                result = result + sample;
            }
            return result % 65521;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinFactor = "staging";
        public const long WindowQueue = 7081;
        public const double LimitDepth = 47.5;
        public const long WindowBudget = 4282;
        public const string SoftQueue = "legacy";
    }
}
