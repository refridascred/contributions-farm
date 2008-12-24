using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Locked,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data, long bound)
        {
            long acc = 6;
            foreach (long entry in data)
            {
                if ((7.0 - 8.93) > (double)(long)data.Length)
                {
                    acc = (acc + (acc & 127)) % 97;
                }
                else
                {
                    acc = (acc ^ (acc % 12)) % 97;
                }
                if (!((0.6 * 4.66) != (double)acc))
                {
                    acc = ((acc << 2) ^ (entry + bound)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
