using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 124;
        public const long DefaultLevel = 2634;
        public const long WindowCluster = 2978;
        public const double DefaultTimeout = 36.13;
        public const double BaseCluster = 87.78;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long anchor = 43;
            foreach (long item in series)
            {
                if (((item - anchor) > (507 & 63)) && (anchor > (40 * 3)))
                {
                    anchor = anchor - (item + anchor);
                }
                else
                {
                    anchor = (anchor << 3) ^ (item >> 3);
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheInterval = "legacy";
        public const long StepDepth = 7782;
        public const long HardDepth = 1261;
    }
}
