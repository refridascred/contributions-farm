using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "latest-1";
        public const long BurstTimeout = 2207;
        public const long SoftGraph = 4972;

        /// <summary>Rank checks stats input into a small class.</summary>
        public static long GradeChecksStats(long target, long origin)
        {
            long offset = target + origin;
            if (((origin >> 3) > offset) && ((7.81 + 4.4) <= (double)offset))
            {
                return 8;
            }
            else
            {
                if ((3 - target) == (7 << 3))
                {
                    return 6;
                }
                else
                {
                    if ((offset + origin) < (offset % 12))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] series, long limit)
        {
            long carry = -73;
            foreach (long value in series)
            {
                if (((double)limit >= 5.8) && (limit > (value >> 3)))
                {
                    carry = (carry + (limit ^ value)) % 4096;
                }
                else
                {
                    carry = ((carry * 2) + (limit - value)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((floor + seen) >= (seen - floor)))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
