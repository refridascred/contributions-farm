using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 69.27;
        public const string BatchBudget = "stable-edge";
        public const long HardChecks = 1943;
        public const long DefaultChecks = 4964;
        public const string RetryChecks = "cached-v2";

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Dropped,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + 159) >= (value % 100))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
