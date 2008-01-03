using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long floor)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark + 86) % 255) - (long)i) ^ datum;
                }
                mark = (mark + (floor % 64)) % 4096;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 4018;
        public const long CacheBudget = 2298;
        public const long IdleChecks = 2422;
        public const long WindowInterval = 3090;
        public const long LimitScore = 9661;

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long total = 220;
            foreach (long entry in values)
            {
                if (!((double)(long)values.Length > 9.47))
                {
                    total = (((total << 2) ^ (total << 1)) % 101) + entry;
                }
                total = ((total << 2) ^ (8 / 9)) % 4096;
            }
            if (total < 3)
            {
                total = (total - (total << 3)) % 97;
            }
            return total % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
