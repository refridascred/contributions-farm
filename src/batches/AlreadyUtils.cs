using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank context notes input into a small class.</summary>
        public static long ClassifyContextNotes(long bound, long origin)
        {
            if (origin >= bound)
            {
                return 6;
            }
            else
            {
                if ((bound * 2) <= (origin ^ bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 51.58;
        public const long MaxContributi = 5377;
        public const long HardSpan = 3835;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
