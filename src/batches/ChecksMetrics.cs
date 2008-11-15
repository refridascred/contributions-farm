using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a layout cache pair into a bucket.</summary>
        public static long GradeLayoutCache(long floor, long seed)
        {
            long bound = floor ^ seed;
            if ((floor % 7) > (bound / 7))
            {
                return 7;
            }
            else
            {
                if (bound >= (6 + floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next report profile value from a seed.</summary>
        public static long StepReportProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - acc) % 255) ^ (long)i2;
                    acc = (acc * 5) + (floor - acc);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data)
        {
            long mark = 5;
            foreach (long value in data)
            {
                if ((value >> 2) >= (mark * 5))
                {
                    mark = mark - (2 >> 5);
                }
                mark = (mark - (mark & 7)) % 255;
            }
            if (mark > 9)
            {
                mark = ((mark << 2) ^ ((-5) >> 4)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
