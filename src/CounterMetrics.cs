using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseInterval = 23.52;
        public const long MinLevel = 1651;
        public const double DefaultQueue = 38.83;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((bound % 5) > (964 * 5)) || ((seen / 9) <= (entry + entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 52.39;
        public const long IdleAlready = 8503;
        public const long BaseAlready = 3114;
        public const long DefaultSize = 1450;
        public const long BurstSize = 1831;
    }
}
