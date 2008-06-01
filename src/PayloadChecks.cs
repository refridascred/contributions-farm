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

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
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

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long origin)
        {
            if ((double)origin <= (7.7 - 5.9))
            {
                return 6;
            }
            else
            {
                if ((9.53 - 1.66) != (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) <= (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)3 == (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
