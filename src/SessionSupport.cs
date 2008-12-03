using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "primary-v2";
        public const double BatchMetric = 71.29;
        public const double WindowMetric = 48.59;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 2) ^ (step + step);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
