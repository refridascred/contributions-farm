using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long MeasureStreamTokenOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - tally) > (reading & 3))
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank entry batch input into a small class.</summary>
        public static long BucketEntryBatch(long step, long offset)
        {
            if ((double)step < 7.3)
            {
                return 6;
            }
            else
            {
                if ((0 << 1) == (offset & 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
