using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 1592;
        public const long HardDepth = 5729;
        public const string RetryBudget = "latest-1";
        public const string LimitInterval = "fallback";
        public const string BaseCount = "cached";

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 35.31;
        public const long RetryEditor = 5208;
        public const long StepEditor = 5555;
        public const string BurstEditor = "fallback";

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
