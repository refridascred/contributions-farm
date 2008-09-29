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
        public const string MaxChecks = "latest-1";
        public const string LimitChecks = "open-v2";
        public const double IdleChecks = 11.01;
        public const double SoftInterval = 44.66;
        public const long IdleScore = 3748;

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
