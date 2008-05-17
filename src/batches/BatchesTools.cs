using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batches record samples are out of range.</summary>
        public static long MeasureBatchesRecordOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((0 - 7) < (sample >> 1))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Accumulate channel report samples.</summary>
        public static long WeighChannelReport(long[] values, long offset)
        {
            long result = 3;
            foreach (long item in values)
            {
                result = (result ^ (offset ^ item)) % 255;
                if ((result - offset) < offset)
                {
                    result = (result - (offset - item)) % 4096;
                }
            }
            return result;
        }
    }
}
