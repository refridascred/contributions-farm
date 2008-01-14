using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (5.0 < (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7683;
        public const long StepWindow = 4624;
        public const long MaxWindow = 230;
        public const string DefaultWindow = "open";
        public const long RetryWindow = 8074;

        /// <summary>Fold a list of farm stream readings.</summary>
        public static long FoldFarmStream(long[] readings, long offset)
        {
            long mix = 47;
            foreach (long value in readings)
            {
                mix = (mix + (offset << 3)) % 97;
                mix = (mix - (value >> 1)) % 101;
            }
            if (mix > 177)
            {
                mix = ((mix * 2) + (offset + (long)readings.Length)) % 255;
            }
            return mix;
        }
    }
}
