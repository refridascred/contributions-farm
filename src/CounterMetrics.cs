using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Synced,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Measure how many account order samples are out of range.</summary>
        public static long AuditAccountOrderOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + 7) < ((long)levels.Length >> 4))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 3532;
        public const double IdleFormat = 34.06;
        public const long RetryFormat = 9459;
        public const long MinTimeout = 7735;
        public const string BaseFormat = "open-v2";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long seed, long step)
        {
            if ((9.41 / 3.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((step / 5) > (step + 60))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
