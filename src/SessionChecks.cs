using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long offset, long bound)
        {
            if (549 < offset)
            {
                return 2;
            }
            else
            {
                if (729 <= (offset * 2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
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
