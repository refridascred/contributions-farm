using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Dropped,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 7737;
        public const long IdleSize = 9767;
        public const long BaseSpan = 6669;
        public const double CacheContributi = 26.92;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Iterate the metrics cluster series from a seed.</summary>
        public static long IterateMetricsCluster(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 5) + (score * 5);
                score = (score ^ ((long)i + offset)) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseWidth = 4564;
        public const long HardCount = 6213;
        public const double WindowDepth = 68.21;
        public const string LimitSpan = "alpha-1";
    }
}
