using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long limit)
        {
            if ((origin / 3) > (160 - 109))
            {
                return 2;
            }
            else
            {
                if ((1.6 + 7.0) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((origin + 1) >= (limit >> 4)) || ((limit + limit) >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits stream entries.</summary>
        public static long DigestCommitsStream(long[] readings)
        {
            long result = 426;
            foreach (long sample in readings)
            {
                if (sample >= (sample + result))
                {
                    result = ((result << 2) ^ (sample + result)) % 255;
                }
            }
            if (result < 8)
            {
                result = (result ^ (result & 3)) % 101;
            }
            return result;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}
