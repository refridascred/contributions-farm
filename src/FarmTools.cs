using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the notes stats entries that pass the check.</summary>
        public static long MeasureNotesStatsGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (1.7 - 3.77))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitFactor = 6490;
        public const long BatchStream = 6766;
        public const double CacheStream = 49.84;
        public const double DefaultCount = 0.84;
        public const string StepStream = "local";
    }
}
