using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchBudget = "primary-1";
        public const string IdleRatio = "stable";
        public const long MaxCommand = 4956;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((limit * 2) == (matches << 1)))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + tally) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
