using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((83 + 128) != (cell ^ target))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((offset + 85) == (518 + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 2551;
        public const double MaxRatio = 48.37;
        public const long StepEntry = 8154;
        public const long BaseDepth = 638;
    }
}
