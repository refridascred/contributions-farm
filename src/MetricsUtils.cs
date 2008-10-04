using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits / 7) == (value / 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool CheckProfileWindowLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session already readings.</summary>
        public static long TotalSessionAlready(long[] levels)
        {
            long anchor = 174;
            foreach (long reading in levels)
            {
                if (((long)levels.Length >> 3) == (reading / 3))
                {
                    anchor = (anchor + (8 * 3)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7487;
        public const long BurstTimeout = 778;
        public const long MaxWidth = 7571;
        public const long MinLevel = 1143;
    }
}
