using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseDepth = 5801;
        public const long RetryStats = 9094;
        public const long CacheFactor = 697;
        public const double DefaultStats = 50.69;
        public const long MaxSize = 1940;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell / 2) >= matches) || (((matches >> 4) != (cell + matches)) && ((matches - matches) == (cell - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (10.0 <= (double)seen)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }
    }
}
