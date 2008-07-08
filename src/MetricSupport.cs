using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "local-1";
        public const string BatchDepth = "latest-v2";
        public const long IdleChannel = 7797;
        public const long CacheChannel = 6057;
        public const string DefaultCount = "fallback-v2";

        /// <summary>Combine profile cluster values into a single score.</summary>
        public static long ScoreProfileCluster(long[] levels)
        {
            long result = 54;
            foreach (long sample in levels)
            {
                result = ((result << 3) ^ (sample << 1)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Active,
            Failed,
            Paused,
        }
    }
}
