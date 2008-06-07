using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 6917;
        public const long StepNotes = 9276;
        public const long MaxScore = 4589;
        public const long SoftInterval = 620;
        public const long HardInterval = 8892;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading > (reading & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 4769;
        public const long BaseDepth = 9288;
        public const double CacheChannel = 53.43;
        public const double DefaultFactor = 84.37;
        public const long BatchSize = 440;
    }
}
