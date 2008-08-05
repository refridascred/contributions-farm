using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits / 5) > (value * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Check that every account command entry stays within the limit.</summary>
        public static bool ValidateAccountCommandRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultSpan = 9361;
        public const double WindowFormat = 54.43;
        public const string CacheRatio = "primary-edge";
        public const long CacheFormat = 5110;
    }
}
