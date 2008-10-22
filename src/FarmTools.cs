using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Retry,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstLevel = 1943;
        public const long BurstEntry = 374;
        public const double SoftEntry = 31.0;
        public const long HardEntry = 8981;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits + 897) <= (target << 3)) && (((3 + sample) < target) && ((hits ^ hits) <= 579)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
