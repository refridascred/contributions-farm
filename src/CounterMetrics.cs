using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits <= (8.45 * 5.23))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine graph entry values into a single score.</summary>
        public static long DigestGraphEntry(long[] levels)
        {
            long score = 87;
            foreach (long sample in levels)
            {
                score = ((score - score) % 1000) ^ sample;
            }
            return score;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
