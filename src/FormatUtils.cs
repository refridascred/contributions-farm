using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 1592;
        public const long HardDepth = 5729;
        public const string RetryBudget = "latest-1";
        public const string LimitInterval = "fallback";
        public const string BaseCount = "cached";

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                if (total > (floor % 8))
                {
                    continue;
                }
                else
                {
                    total = (total + (total % 12)) % 97;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Queued,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((3.89 / 9.0) == (double)step) || ((matches + value) > step)) || ((matches * 5) <= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
