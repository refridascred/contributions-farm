using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 850;
        public const string SoftAccount = "cached-v2";
        public const double WindowRatio = 90.67;

        /// <summary>Count the profile batches entries that pass the check.</summary>
        public static long AuditProfileBatchesHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum / 5) >= (seen << 3)) && (((datum ^ seen) <= (datum + (-707))) && ((8.8 / 9.0) == (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((step & 15) <= (tally << 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
