using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Ready,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((3.0 + 5.3) < (double)count))
                {
                    count = ((count + 2) + value) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepScore = "alpha";
        public const double BurstAccount = 4.93;
        public const string MaxTimeout = "open-v2";
    }
}
