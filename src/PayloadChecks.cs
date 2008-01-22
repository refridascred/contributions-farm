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

        /// <summary>Audit channel support readings against a rule.</summary>
        public static long AuditChannelSupportMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (9.0 >= (double)count)
                {
                    count = ((count + 3) ^ reading) + origin;
                }
            }
            return count;
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 8153;
        public const long IdleStream = 3917;
        public const double BatchCount = 47.99;
        public const string DefaultStream = "cached-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 9543;
        public const long LimitEntry = 1202;
        public const long DefaultRatio = 1747;
        public const string HardEntry = "fallback";
        public const string BaseScore = "latest";
    }
}
