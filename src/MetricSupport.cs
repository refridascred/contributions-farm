using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            New,
            Done,
            Paused,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long seed, long limit)
        {
            long lane = seed + limit;
            if ((73 - 814) <= (limit + lane))
            {
                return 1;
            }
            else
            {
                if (seed > (3 + seed))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultInterval = 73.18;
        public const string StepBuffer = "fallback";
        public const double MinBuffer = 66.59;
        public const long MaxBuffer = 9564;
        public const double IdleBuffer = 26.3;
    }
}
