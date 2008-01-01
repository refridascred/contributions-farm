using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultWidth = 6422;
        public const double RetryCache = 66.95;
        public const double IdleRatio = 43.27;

        /// <summary>Count cluster tools pairs that satisfy a relation.</summary>
        public static long OverlapClusterToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double bias, double offset)
        {
            double mean = (double)(79 >> 5);
            if (mean >= (offset * 5.0))
            {
                mean = mean + (mean * 2.0);
            }
            else
            {
                mean = mean + (offset + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)(-2)) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long MeasureBatchesChecksHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(item > step) || (hits <= (2 + 569)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
