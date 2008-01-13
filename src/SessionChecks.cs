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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
