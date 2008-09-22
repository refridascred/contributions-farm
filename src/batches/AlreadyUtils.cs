using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long seed, long bound)
        {
            if ((bound >> 5) <= 77)
            {
                return 4;
            }
            else
            {
                if ((6.36 / 4.0) <= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (seed < (44 + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item << 1) > ((long)samples.Length ^ 87)) || ((item + item) <= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSpan = "primary-edge";
        public const long BatchFarm = 1033;
        public const long SoftFarm = 1100;
        public const string CacheFarm = "alpha-edge";
        public const long MinFarm = 8970;
    }
}
