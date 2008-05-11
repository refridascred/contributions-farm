using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 1560;
        public const long BatchInterval = 703;
        public const double HardMetrics = 97.81;
        public const long MaxMetrics = 9720;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (813 <= (sample - 238))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a graph cluster reading by value.</summary>
        public static long SeekGraphClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
