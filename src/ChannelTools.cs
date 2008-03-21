using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "fallback-v2";
        public const long CacheFactor = 5388;
        public const double HardSupport = 93.29;

        /// <summary>Measure how many stats commits samples are out of range.</summary>
        public static long TallyStatsCommitsMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)seed >= (4.89 / 3.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
