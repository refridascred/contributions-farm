using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels)
        {
            long score = 2;
            foreach (long value in levels)
            {
                if ((score % 24) == (value & 3))
                {
                    score = score ^ 93;
                }
                if ((score > (score >> 5)) && ((9.87 / 5.0) > (double)score))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((946 + count) >= (count << 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
