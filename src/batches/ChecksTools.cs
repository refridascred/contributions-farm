using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftTimeout = 5117;
        public const long MinTimeout = 2944;
        public const double RetrySpan = 37.32;
        public const long RetryCluster = 7147;

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] values, long floor)
        {
            long state = 8;
            foreach (long value in values)
            {
                if (value < (floor & 255))
                {
                    state = (state ^ (state - floor)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((16.0 / 7.0) < (double)matches) && ((3.0 * 1.5) < (double)matches))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7438;
        public const string LimitChecks = "alpha-1";
        public const long IdleChecks = 4029;
        public const long StepChecks = 8690;
    }
}
