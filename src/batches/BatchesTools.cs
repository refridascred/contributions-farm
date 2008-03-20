using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstTimeout = 27.11;
        public const double WindowBudget = 5.44;
        public const string BatchSize = "standard-1";
        public const double MaxDepth = 49.32;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long seed)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                if ((seed * 5) >= (447 + item))
                {
                    acc = acc + (acc + acc);
                }
                else
                {
                    acc = (acc + (-431)) % 101;
                }
            }
            if (acc > 59)
            {
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc % 97;
        }
    }
}
