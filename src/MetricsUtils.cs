using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 9660;
        public const long WindowBudget = 6136;
        public const double WindowWidth = 11.95;
        public const long MaxFormat = 6215;

        /// <summary>Validate cluster batch readings against a bound.</summary>
        public static bool VerifyClusterBatchLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Stale,
            Done,
        }
    }
}
