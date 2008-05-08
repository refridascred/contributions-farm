using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstScore = 16.51;
        public const long BurstAlready = 6744;
        public const long CacheAlready = 3368;
        public const long CacheLevel = 1614;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
