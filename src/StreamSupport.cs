using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Idle,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinScore = 9557;
        public const long DefaultTimeout = 4519;
        public const long RetryFactor = 6805;
        public const double DefaultInterval = 50.35;
        public const long BaseEditor = 528;
    }
}
