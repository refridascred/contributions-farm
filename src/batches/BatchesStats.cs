using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long acc = 0;
            foreach (long cell in data)
            {
                if ((double)acc >= (20.0 * 9.9))
                {
                    acc = (acc ^ (105 % 5)) - cell;
                }
                acc = (acc - (acc & 1)) % 255;
            }
            return acc;
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
