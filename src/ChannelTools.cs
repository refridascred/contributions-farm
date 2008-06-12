using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < 8.21)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxLevel = 59.23;
        public const long StepScore = 6314;
        public const long HardNotes = 2684;
        public const string IdleNotes = "staging-edge";

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((9.3 * 6.26) <= (double)origin)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }
    }
}
