using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long step)
        {
            if (((step * 4) != (target - target)) || ((double)target > (6.4 + 2.4)))
            {
                return 8;
            }
            else
            {
                if ((53 + step) < (-98))
                {
                    return 5;
                }
                else
                {
                    if ((1.4 / 5.0) == (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((sample + hits) <= (hits - sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
