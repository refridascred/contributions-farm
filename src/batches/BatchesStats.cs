using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 4565;
        public const long WindowChecks = 5162;
        public const long WindowRatio = 1249;
        public const string DefaultDepth = "primary-v2";
        public const long HardChecks = 7537;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of order metrics readings.</summary>
        public static long CombineOrderMetrics(long[] readings)
        {
            long acc = 189;
            foreach (long item in readings)
            {
                acc = ((acc * 5) + (acc >> 2)) + item;
            }
            return acc % 1000;
        }
    }
}
