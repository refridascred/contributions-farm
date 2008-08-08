using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1447;
        public const double BaseDepth = 94.64;
        public const long DefaultLevel = 153;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell / 9) <= (matches ^ 894)) || (matches <= (matches & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((bound * 5) > (datum - 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
