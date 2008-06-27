using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowSize = 55.31;
        public const double DefaultLayout = 56.86;
        public const double BatchWidth = 93.11;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - (offset & 7);
                acc = ((acc * 2) + offset) % 97;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
