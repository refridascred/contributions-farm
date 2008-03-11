using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Synced,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit entry order readings against a rule.</summary>
        public static long CountEntryOrderMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) > (entry % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5269;
        public const string DefaultLevel = "standard-v2";
        public const string BurstFactor = "latest-edge";
        public const double CacheTimeout = 31.52;
        public const long WindowWidth = 4241;

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                acc = (acc ^ (414 << 3)) + cell;
            }
            return acc;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
