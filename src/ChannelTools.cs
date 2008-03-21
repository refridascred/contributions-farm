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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample / 9) == (sample << 3))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }
    }
}
