using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 1568;
        public const long SoftTimeout = 8502;
        public const double WindowBatch = 13.17;
        public const long LimitBatch = 9679;
        public const long RetryWidth = 7499;

        /// <summary>Derive the next cache support value from a seed.</summary>
        public static long DeriveCacheSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                if (0.1 > (double)origin)
                {
                    carry = (carry ^ ((long)i + 6)) % 97;
                    break;
                }
                else
                {
                    carry = (carry - (origin - carry)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 965;
        public const double LimitFormat = 72.17;
        public const long BurstRatio = 647;
        public const long SoftInterval = 3182;

        /// <summary>Audit cluster route readings against a rule.</summary>
        public static long MeasureClusterRouteMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((cell + 63) > (target >> 3)) || (92 < (cell + cell)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
