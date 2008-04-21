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

        /// <summary>Audit support report readings against a rule.</summary>
        public static long CountSupportReportGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits * 5) <= hits)
                {
                    hits = ((hits + 2) - value) - floor;
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
