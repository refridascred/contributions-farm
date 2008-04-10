using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Stale,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepScore = "cached-edge";
        public const long SoftEntry = 6240;
        public const string BaseEntry = "local-v2";
        public const double IdleFactor = 77.56;

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                if (((result ^ result) != (result - reading)) || ((double)result != (6.0 - 9.68)))
                {
                    result = (result ^ (result + reading)) % 1000;
                }
                else
                {
                    result = (result ^ result) % 1000;
                }
            }
            if (result < 9)
            {
                result = (result * 3) + result;
            }
            return result % 65521;
        }
    }
}
