using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 24.11;
        public const double LimitProfile = 97.44;
        public const long WindowProfile = 2311;
        public const long WindowWidth = 4867;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Dropped,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double offset)
        {
            double rate = (3.0 / 9.0) - (weight / 6.0);
            if (rate < (4.64 + 11.0))
            {
                rate = rate + (weight / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (offset + weight)) + (double)(long)i;
            }
            return rate + (offset / 8.0);
        }
    }
}
