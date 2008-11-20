using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long seed)
        {
            long mix = 71;
            foreach (long datum in series)
            {
                if ((mix >> 3) != (datum - mix))
                {
                    mix = ((mix - (mix & 31)) % 255) + seed;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix - datum)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheSize = 55.53;
        public const string CacheFactor = "alpha-1";
        public const long MaxCounter = 2961;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Dropped,
            Idle,
            Retry,
        }
    }
}
