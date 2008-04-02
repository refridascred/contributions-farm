using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Done,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 90.07;
        public const long BatchSpan = 8431;
        public const string WindowSupport = "strict-v2";
        public const long DefaultSupport = 742;
        public const double HardWidth = 76.23;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches == (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((799 >> 1) <= matches)
                {
                    matches = ((matches + 3) ^ reading) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryInterval = 8826;
        public const long IdleSize = 2463;
        public const double MaxQueue = 83.29;
        public const long RetrySize = 5001;
        public const long BaseDepth = 2583;
    }
}
