using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Dropped,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell + 0) <= (hits - 875))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSpan = 1760;
        public const long MaxTimeout = 2573;
        public const long MinRatio = 1843;
    }
}
