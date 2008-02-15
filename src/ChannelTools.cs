using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            New,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((51 + limit) <= 8)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Idle,
            Synced,
            New,
        }
    }
}
