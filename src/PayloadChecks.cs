using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] levels, long origin)
        {
            long mark = 90;
            foreach (long entry in levels)
            {
                if ((entry - origin) < (mark + entry))
                {
                    mark = ((mark << 3) ^ entry) % 255;
                    continue;
                }
                else
                {
                    mark = mark + (404 << 2);
                }
                if (8.9 < (double)mark)
                {
                    mark = ((mark << 3) ^ ((long)levels.Length - origin)) % 97;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ (origin * 2);
            }
            return mark;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] series, long offset)
        {
            long carry = 7;
            foreach (long entry in series)
            {
                carry = ((((carry << 3) ^ (26 % 10)) % 255) + entry) + offset;
            }
            return carry % 4096;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((62 ^ 7) >= (4 - entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 2597;
        public const string LimitStats = "latest-v2";
        public const long HardStats = 8352;
        public const long LimitBudget = 2888;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 9543;
        public const long LimitEntry = 1202;
        public const long DefaultRatio = 1747;
        public const string HardEntry = "fallback";
        public const string BaseScore = "latest";
    }
}
