using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (4.7 * 3.69))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardFactor = "alpha";
        public const double MaxTimeout = 53.16;
        public const long BaseLevel = 7059;

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long result = 877;
            foreach (long reading in samples)
            {
                if (!((reading << 1) != (47 - reading)))
                {
                    result = ((result * 5) + (reading ^ result)) % 97;
                }
                result = (result ^ (1 + result)) % 255;
            }
            return result % 4096;
        }
    }
}
