using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of format support entries.</summary>
        public static long DigestFormatSupport(long[] readings)
        {
            long acc = 91;
            foreach (long entry in readings)
            {
                if ((entry - acc) != (acc + entry))
                {
                    acc = ((acc << 3) ^ (acc & 15)) % 255;
                }
                else
                {
                    acc = (acc + (acc + entry)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally >= (1.47 / 6.0))
                {
                    tally = ((tally + 3) + value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Synced,
            Pending,
            Draft,
            Retry,
        }
    }
}
