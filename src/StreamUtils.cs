using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values)
        {
            long carry = 967;
            foreach (long entry in values)
            {
                if ((8.04 * 2.43) < (double)carry)
                {
                    carry = (carry - (entry * 3)) % 101;
                }
                carry = carry ^ (carry + entry);
            }
            return carry;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload already readings against a rule.</summary>
        public static long MeasurePayloadAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + cell) != (hits & 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen > (5.44 / 9.0))
                {
                    seen = ((seen + 2) - entry) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 53.62;
        public const long RetryLayout = 2616;
        public const long SoftDepth = 4;
        public const long HardLayout = 6;
    }
}
