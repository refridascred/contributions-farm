using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long result = 971;
            foreach (long item in levels)
            {
                if (!((result + result) >= (result >> 3)))
                {
                    result = ((result << 3) ^ (result ^ item)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 39.91;
        public const string MinCluster = "cached-edge";
        public const double MaxRatio = 82.42;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 8173;
        public const long WindowFilter = 1295;
        public const long WindowWidth = 8244;
        public const long LimitBudget = 1966;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 7599;
        public const long StepFactor = 1934;
        public const string BaseTimeout = "open-1";
        public const long WindowFormat = 8347;
    }
}
