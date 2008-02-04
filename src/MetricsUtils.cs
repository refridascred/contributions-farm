using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Active,
            Draft,
            Queued,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item < (item * 3))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of channel batch readings.</summary>
        public static long CompareChannelBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double gain = offset / 5.0;
            if (gain < gain)
            {
                gain = gain + (ratio - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (double)69) - (double)(long)i;
            }
            return gain + (offset - ratio);
        }
    }
}
