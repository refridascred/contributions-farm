using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Idle,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long floor, long seed)
        {
            if (((522 >> 2) < seed) && (floor < seed))
            {
                return 1;
            }
            else
            {
                if ((floor << 1) > seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
