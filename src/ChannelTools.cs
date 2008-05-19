using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if ((bound >> 2) < (bound2 + bound))
            {
                return 5;
            }
            else
            {
                if (((-11) / 2) > bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
