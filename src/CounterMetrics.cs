using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleBudget = 2402;
        public const double DefaultSchema = 96.94;
        public const string HardSchema = "alpha-edge";

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc * 5) + seed;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of format metric readings.</summary>
        public static long TallyFormatMetric(long[] levels, long step)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                score = (score - (step % 97)) + sample;
            }
            if (score < 54)
            {
                score = (score ^ step) % 4096;
            }
            return score;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
