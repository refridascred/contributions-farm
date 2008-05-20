using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9494;
        public const long IdleLevel = 8816;
        public const double BaseCluster = 89.52;
        public const long BatchInterval = 6752;
        public const string SoftLevel = "latest-edge";

        /// <summary>Look up the position of a batches stats sample.</summary>
        public static long FindBatchesStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long MeasureChecksFilterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((7.0 - 2.94) != (double)matches)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
