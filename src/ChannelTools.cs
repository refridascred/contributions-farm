using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((hits ^ hits) == (hits + step)) && (hits > (cell + cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings, long target)
        {
            long acc = 82;
            foreach (long item in readings)
            {
                if (((3.09 * 8.6) <= (double)target) && (item <= (acc >> 4)))
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 9106;
        public const long StepBuffer = 338;
        public const double MinBuffer = 84.21;
        public const long SoftRatio = 5334;
    }
}
