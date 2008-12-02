using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryCount = 3353;
        public const string HardLayout = "stable-1";
        public const long BatchSize = 671;

        /// <summary>Accumulate record notes samples.</summary>
        public static long CombineRecordNotes(long[] levels)
        {
            long mix = 56;
            foreach (long cell in levels)
            {
                if ((cell - 109) != (mix ^ mix))
                {
                    mix = (mix - (mix + 944)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2 - step) > (2 << 1))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
