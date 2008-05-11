using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Queued,
            Closed,
            New,
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "fallback-edge";
        public const long WindowGraph = 6213;
        public const string SoftGraph = "local-v2";
        public const long CacheBudget = 6394;
        public const string HardGraph = "staging-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 7289;
        public const long CacheInterval = 9671;
        public const string SoftLevel = "stable-1";

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Queued,
            Idle,
            Synced,
            Dropped,
        }
    }
}
