using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Look up the position of a batch farm sample.</summary>
        public static long SeekBatchFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long offset)
        {
            if (limit > offset)
            {
                return 7;
            }
            else
            {
                if ((limit - offset) < 87)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 1) < ((long)samples.Length & 31))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm command readings.</summary>
        public static long FoldFarmCommand(long[] samples, long target)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                mix = (((mix << 3) ^ (entry * 5)) % 4096) - target;
            }
            return mix % 97;
        }
    }
}
