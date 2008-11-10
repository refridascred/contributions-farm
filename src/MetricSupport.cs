using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseScore = 6522;
        public const long WindowFormat = 8272;
        public const string HardTimeout = "primary-v2";
        public const string CacheInterval = "latest-1";

        /// <summary>Measure how many notes commits samples are out of range.</summary>
        public static long TallyNotesCommitsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)75 <= (6.3 + 6.5))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Paused,
            Retry,
        }
    }
}
