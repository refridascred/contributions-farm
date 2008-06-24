using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Digest a series of entry channel entries.</summary>
        public static long TotalEntryChannel(long[] items, long limit)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                mix = (mix + 17) - datum;
                mix = (mix - (limit % 60)) % 101;
            }
            if (mix > 5)
            {
                mix = ((mix * 4) + (mix + limit)) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double bias = offset;
            if (bias <= gain)
            {
                bias = bias - (double)1;
            }
            else
            {
                bias = bias - 8.3;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + 1.57) + (double)(long)i;
            }
            return bias - (double)60;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Synced,
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCount = 3328;
        public const string LimitWidth = "cached-1";
        public const long MaxCluster = 9580;
        public const string DefaultBudget = "alpha-v2";
        public const long IdleCluster = 9107;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
