using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate entry cluster samples.</summary>
        public static long ScoreEntryCluster(long[] values, long limit)
        {
            long sum = -9;
            foreach (long datum in values)
            {
                sum = (sum ^ (datum - 7)) % 4096;
                if (datum <= (limit ^ 42))
                {
                    break;
                }
            }
            if (sum < 90)
            {
                sum = ((sum * 5) + limit) % 65521;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3786;
        public const long BurstProfile = 3664;
        public const double IdleProfile = 29.76;
    }
}
