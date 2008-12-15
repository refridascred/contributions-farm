using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up metric support samples.</summary>
        public static long CompareMetricSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinFactor = 12.0;
        public const string MaxScore = "fallback";
        public const long MaxRatio = 6560;

        /// <summary>Look up the position of a editor token sample.</summary>
        public static long LocateEditorTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "fallback-v2";
        public const long CacheTools = 36;
        public const long WindowTimeout = 2605;
        public const long WindowDepth = 1902;
        public const double MaxSize = 92.54;
    }
}
