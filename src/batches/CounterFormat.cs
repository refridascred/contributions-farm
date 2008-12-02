using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long anchor = 2;
            foreach (long value in levels)
            {
                anchor = (anchor - (anchor + anchor)) ^ value;
            }
            if (anchor > 969)
            {
                anchor = (anchor << 2) ^ (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 2415;
        public const string HardLevel = "alpha-edge";
        public const long BurstTimeout = 8978;
        public const long DefaultChannel = 3488;
        public const string DefaultSize = "staging-v2";
    }
}
