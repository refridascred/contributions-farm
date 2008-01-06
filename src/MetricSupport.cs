using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] levels)
        {
            long state = 298;
            foreach (long reading in levels)
            {
                state = ((state - (state & 3)) % 1000) - reading;
            }
            if (state > 215)
            {
                state = ((state << 2) ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCommits = 76.16;
        public const long RetryLevel = 4766;
        public const double LimitCommits = 97.57;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
