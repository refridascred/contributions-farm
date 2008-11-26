using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 7591;
        public const long MinLevel = 2003;
        public const long HardEntry = 7510;
        public const long DefaultEntry = 5576;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5654;
        public const long LimitNotes = 4984;
        public const long RetryFactor = 7492;
        public const long BurstFactor = 1960;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((8 <= (value ^ offset)) && !((value - value) <= value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
