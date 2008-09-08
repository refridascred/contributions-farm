using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 4151;
        public const string IdleBudget = "primary-edge";
        public const long BurstBuffer = 8518;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Pending,
            Retry,
            New,
            Paused,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (limit << 2)) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
