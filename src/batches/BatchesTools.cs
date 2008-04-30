using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSize = 7497;
        public const double CacheStats = 61.92;
        public const long StepInterval = 1436;
        public const long BaseScore = 5594;
        public const long IdleStats = 1315;

        /// <summary>Find the first schema batches entry that matches the target.</summary>
        public static long LocateSchemaBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
