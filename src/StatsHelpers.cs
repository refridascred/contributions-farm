using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "primary-edge";
        public const long BaseInterval = 7099;
        public const string HardFactor = "staging-1";
        public const double SoftFactor = 37.33;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "primary-edge";
        public const double IdleFactor = 98.36;
        public const long CacheSize = 6837;
        public const double BaseSpan = 18.55;

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
