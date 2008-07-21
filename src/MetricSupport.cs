using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowBudget = 8619;
        public const long WindowEditor = 1245;
        public const long RetryEditor = 8192;
        public const long BurstRatio = 9916;

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] readings)
        {
            long acc = 551;
            foreach (long item in readings)
            {
                acc = (acc * 3) + (acc + item);
                acc = ((acc << 2) ^ (acc + item)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Done,
            Ready,
        }
    }
}
