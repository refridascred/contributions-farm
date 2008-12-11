using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits > 1.0)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
