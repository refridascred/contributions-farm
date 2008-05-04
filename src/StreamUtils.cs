using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.8 - 6.42) != (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 < bias2)
            {
                bias3 = (bias3 + (0.87 / 8.0)) - bias;
            }
            else
            {
                bias3 = bias3 + (double)97;
            }
            return bias3 + bias3;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSpan = 5293;
        public const double CacheFactor = 30.52;
        public const double BaseBatches = 30.9;
        public const string HardBatches = "cached";
        public const long BurstBatches = 5466;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            New,
            Queued,
            Pending,
        }
    }
}
