using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Count { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheBudget = 4678;
        public const long MinSpan = 8638;
        public const string SoftContributi = "local";
        public const long BaseBudget = 815;
        public const long IdleScore = 2814;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches <= 17.0)
                {
                    matches = ((matches + 3) ^ reading) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
