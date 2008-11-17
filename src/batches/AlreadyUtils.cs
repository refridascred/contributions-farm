using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long bound)
        {
            if (((offset - 533) != (4 & 7)) || ((24 >> 4) >= (offset - bound)))
            {
                return 4;
            }
            else
            {
                if (((offset << 2) > offset) && ((double)809 > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound >= (5.2 * 9.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long CombineQueueMetrics(long[] items)
        {
            long score = -545;
            foreach (long value in items)
            {
                if (4.3 >= (double)score)
                {
                    score = (score - value) % 1000;
                }
            }
            return score;
        }

        /// <summary>Digest a series of buffer cache entries.</summary>
        public static long TotalBufferCache(long[] items, long origin)
        {
            long mark = 545;
            foreach (long item in items)
            {
                mark = ((mark + (origin + (-657))) % 1000) + item;
            }
            if (mark > 94)
            {
                mark = (mark + origin) % 101;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long score = 7;
            foreach (long sample in readings)
            {
                score = (score + (score + sample)) % 97;
                score = score - score;
            }
            return score;
        }
    }
}
