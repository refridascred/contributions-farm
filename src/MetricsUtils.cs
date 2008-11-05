using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches counter entries.</summary>
        public static long FoldBatchesCounter(long[] items)
        {
            long anchor = 975;
            foreach (long sample in items)
            {
                anchor = (anchor - (anchor >> 2)) - sample;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheDepth = 395;
        public const long BaseBatch = 5753;
        public const double CacheSpan = 96.46;
        public const string RetryDepth = "standard-v2";

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long TallyToolsReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((344 & 31) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = mix ^ ((long)i % 3);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
