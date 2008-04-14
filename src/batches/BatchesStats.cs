using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Dropped,
            Stale,
            Draft,
            Failed,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items, long seed)
        {
            long score = 774;
            foreach (long cell in items)
            {
                score = (((score << 3) ^ cell) % 101) - seed;
            }
            return score;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double scale, double span)
        {
            double drift = span * 3.0;
            return (drift + (drift / 7.0)) + scale;
        }
    }
}
