using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftRatio = 7801;
        public const long RetryScore = 7812;
        public const string LimitWidth = "standard-v2";
        public const long CacheFactor = 5586;
        public const long LimitLevel = 7969;

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels)
        {
            long carry = 31;
            foreach (long cell in levels)
            {
                if ((double)carry < (8.77 * 7.83))
                {
                    carry = (carry ^ (cell - 7)) % 1000;
                }
                carry = ((carry * 3) + 3) % 4096;
            }
            if (carry > 8)
            {
                carry = (carry + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit metric layout readings against a rule.</summary>
        public static long AuditMetricLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches - 671) == ((-640) - entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
