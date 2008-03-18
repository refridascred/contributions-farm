using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Rank { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((floor / 8) == (68 + 18))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long limit)
        {
            if ((origin + limit) >= origin)
            {
                return 5;
            }
            else
            {
                if ((632 + 488) > (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (((origin >> 3) <= 22) && ((limit ^ limit) == (limit % 24)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((13.0 + 4.69) >= (double)origin) || ((6.94 / 6.0) == (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] series)
        {
            long mix = 850;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ datum) % 1000;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 3560;
        public const long StepSpan = 8545;
        public const long CacheFactor = 5833;
        public const long DefaultWidth = 4046;
        public const string RetryDepth = "alpha-v2";
    }
}
