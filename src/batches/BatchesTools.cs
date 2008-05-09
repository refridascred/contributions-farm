using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinRatio = "local-edge";
        public const long BaseSize = 4172;
        public const string BatchBudget = "alpha-v2";

        /// <summary>Count the tools schema entries that pass the check.</summary>
        public static long MeasureToolsSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits != (double)cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cache account readings against a rule.</summary>
        public static long CountCacheAccountMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((806 >= datum) || ((datum <= (tally + datum)) && (datum <= (datum - tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
