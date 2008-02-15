using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 60;
        public const string DefaultBatches = "alpha";
        public const long WindowLevel = 907;
        public const double CacheLevel = 27.55;
        public const long HardBatches = 9251;

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitTimeout = 9509;
        public const string WindowSchema = "standard-edge";
        public const long CacheSchema = 2856;
        public const long BaseRatio = 8024;
    }
}
