using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + hits) >= (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = mix - (mix - mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 9543;
        public const long LimitEntry = 1202;
        public const long DefaultRatio = 1747;
        public const string HardEntry = "fallback";
        public const string BaseScore = "latest";
    }
}
