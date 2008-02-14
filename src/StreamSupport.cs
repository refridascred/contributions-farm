using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (4.4 <= (double)tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "fallback-edge";
        public const double BurstFactor = 54.63;
        public const long RetryInterval = 8342;
        public const long BurstSize = 2593;
    }
}
