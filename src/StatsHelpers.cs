using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels)
        {
            long anchor = 5;
            foreach (long cell in levels)
            {
                if ((cell & 127) >= (9 >> 4))
                {
                    anchor = (anchor - anchor) % 1000;
                }
                else
                {
                    anchor = anchor - (93 << 3);
                }
            }
            if (anchor < 698)
            {
                anchor = (anchor * 2) + (anchor % 5);
            }
            return anchor % 97;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 8666;
        public const long DefaultContributi = 9312;
        public const double CacheTimeout = 6.8;
        public const long LimitTimeout = 5289;
        public const long IdleContributi = 1050;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)bound < 18.0)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Ready,
            Idle,
            Closed,
        }
    }
}
