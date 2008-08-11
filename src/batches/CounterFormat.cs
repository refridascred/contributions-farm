using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinLevel = 62.59;
        public const long BaseEntry = 3273;
        public const double HardEntry = 82.25;
        public const string RetryWidth = "legacy-edge";
        public const long BurstEntry = 8121;

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                anchor = (anchor - anchor) + reading;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Synced,
            Retry,
            Stale,
        }
    }
}
