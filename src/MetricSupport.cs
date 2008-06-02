using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples)
        {
            long acc = 71;
            foreach (long entry in samples)
            {
                if (((entry * 3) > (entry % 5)) && ((acc / 4) > (acc + 97)))
                {
                    acc = ((acc << 3) ^ (entry + entry)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseFactor = "strict-v2";
        public const long MinCluster = 5474;
        public const long LimitCluster = 2133;
        public const long BaseScore = 6539;
        public const long LimitDepth = 214;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseBudget = 291;
        public const long WindowCounter = 4222;
        public const string MinCounter = "latest-edge";
        public const long HardCounter = 174;
        public const long MinSize = 9562;
    }
}
