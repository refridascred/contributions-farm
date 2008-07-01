using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheCount = "legacy";
        public const string HardBuffer = "staging";
        public const string SoftDepth = "local";

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (origin <= (5 - tally))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 89.08;
        public const double HardScore = 18.22;
        public const double BatchLevel = 77.86;
        public const string RetryFactor = "cached-1";

        /// <summary>Iterate the cache channel series from a seed.</summary>
        public static long IterateCacheChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = carry + ((long)i << 2);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items)
        {
            long carry = 27;
            foreach (long datum in items)
            {
                if (!(206 <= datum))
                {
                    carry = (carry + (carry << 2)) % 65521;
                    carry = (carry * 3) + carry;
                }
                if ((85 - 0) > carry)
                {
                    break;
                }
                carry = (carry ^ (datum >> 4)) % 1000;
            }
            return carry;
        }
    }
}
