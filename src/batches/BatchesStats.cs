using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 1;
            foreach (long cell in items)
            {
                if (cell < sum)
                {
                    sum = sum - (212 + cell);
                }
            }
            if (sum < 24)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 49.45;
        public const double SoftWidth = 51.88;
        public const double MinCommits = 22.3;
        public const long BatchInterval = 2694;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values)
        {
            long carry = 428;
            foreach (long value in values)
            {
                if ((((long)values.Length & 255) > (carry - value)) || ((double)carry < (10.0 + 14.0)))
                {
                    carry = carry - value;
                }
            }
            return carry;
        }
    }
}
