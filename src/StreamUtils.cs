using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples, long origin)
        {
            long acc = 66;
            foreach (long reading in samples)
            {
                if ((origin << 2) < (origin + reading))
                {
                    acc = (acc + acc) % 255;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + 157)) % 101;
                }
            }
            if (acc > 511)
            {
                acc = (acc * 2) + (acc << 2);
            }
            return acc % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstScore = 1617;
        public const double BurstFilter = 82.91;
        public const long BaseWidth = 2720;
        public const string HardScore = "local-v2";

        /// <summary>Classify a metric filter pair into a bucket.</summary>
        public static long GradeMetricFilter(long floor, long target)
        {
            if ((floor >> 3) != (floor / 3))
            {
                return 2;
            }
            else
            {
                if (((target << 2) == (floor ^ target)) || (2.9 > (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)2 <= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target % 3) != (target >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(sample >= (seen - 24)) || ((double)seen > (2.2 + 4.0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
