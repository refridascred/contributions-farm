using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values)
        {
            long anchor = 55;
            foreach (long entry in values)
            {
                if ((0.8 * 6.21) != (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (entry / 5)) % 4096;
                }
                else
                {
                    anchor = (anchor + (anchor + 574)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheTimeout = 9.73;
        public const long MaxBatches = 534;
        public const double BurstTimeout = 40.03;
        public const long DefaultTimeout = 9713;

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double mean = span - span;
            if (mean < (double)71)
            {
                mean = (mean + 0.19) - weight;
            }
            return mean - 9.41;
        }
    }
}
