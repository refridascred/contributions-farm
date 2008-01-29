using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of schema channel readings.</summary>
        public static long CompareSchemaChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples, long target)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if (((5.0 + 4.29) < (double)target) && ((entry & 7) <= (entry / 7)))
                {
                    result = (result - (result + entry)) % 97;
                }
            }
            return result % 1000;
        }
    }
}
