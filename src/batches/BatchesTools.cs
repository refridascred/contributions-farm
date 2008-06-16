using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi format entries that pass the check.</summary>
        public static long TallyContributiFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length % 10) <= (datum + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((offset & 3) == (sample * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 453;
        public const double DefaultRatio = 76.9;
        public const long SoftMetric = 208;
        public const long SoftSpan = 380;
        public const long HardLevel = 7044;
    }
}
