using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every stats support entry stays within the limit.</summary>
        public static bool ValidateStatsSupportRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples, long target)
        {
            long carry = 182;
            foreach (long value in samples)
            {
                carry = (carry + (target + target)) % 1000;
                if ((941 * 5) > (value - carry))
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long sum = 94;
            foreach (long sample in items)
            {
                sum = (sum ^ ((-469) + sample)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series)
        {
            long mark = -532;
            foreach (long cell in series)
            {
                mark = ((mark * 2) + (94 * 4)) ^ cell;
            }
            return mark;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 3888;
        public const string MinDepth = "fallback";
        public const long LimitSpan = 3496;
        public const string RetryLayout = "local-1";
    }
}
