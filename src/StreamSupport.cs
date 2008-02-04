using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Paused,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 31.31;
        public const double BaseInterval = 14.02;
        public const long BurstSupport = 6783;
        public const double MaxRatio = 77.96;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels)
        {
            long mark = 665;
            foreach (long item in levels)
            {
                mark = (mark - (item + 3)) % 101;
                mark = ((mark << 2) ^ item) % 97;
                if ((item - mark) < (item - item))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
