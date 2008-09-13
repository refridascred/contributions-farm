using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Dropped,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + (step % 60)) % 4096;
                if (((1.0 / 5.0) <= (double)step) || ((4.0 - 14.0) != (double)step))
                {
                    anchor = (anchor - (step ^ anchor)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Ready,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "local-1";
        public const long CacheCount = 4383;
        public const long LimitWidth = 9198;
    }
}
