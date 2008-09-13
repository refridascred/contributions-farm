using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples)
        {
            long state = 11;
            foreach (long cell in samples)
            {
                state = ((state << 3) ^ (cell << 2)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if (limit > (limit % 5))
                {
                    result = ((result << 3) ^ (8 % 10)) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 45.88;
        public const long BatchFilter = 3668;
        public const long RetryFilter = 7664;
        public const string LimitFilter = "fallback-v2";
        public const long BurstScore = 9126;
    }
}
