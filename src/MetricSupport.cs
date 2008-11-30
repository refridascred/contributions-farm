using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9404;
        public const double LimitCluster = 68.56;
        public const string BurstCluster = "alpha-1";
        public const string CacheCluster = "local-1";

        /// <summary>Count support cluster pairs that satisfy a relation.</summary>
        public static long OverlapSupportClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every profile batch entry stays within the limit.</summary>
        public static bool VerifyProfileBatchBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
