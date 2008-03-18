using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 3560;
        public const long StepSpan = 8545;
        public const long CacheFactor = 5833;
        public const long DefaultWidth = 4046;
        public const string RetryDepth = "alpha-v2";
    }
}
