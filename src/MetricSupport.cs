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

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
