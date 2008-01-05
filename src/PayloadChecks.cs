using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a buffer farm sample.</summary>
        public static long FindBufferFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout record figure with a bias.</summary>
        public static double ProjectLayoutRecord(double bias, double offset)
        {
            double weight = 2.8;
            if (weight <= (double)5)
            {
                weight = (weight + bias) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias - bias)) - (double)(long)i;
            }
            return weight - (double)(-902);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 81.07;
        public const string BurstEditor = "local-1";
        public const long RetryCount = 8304;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) > (hits + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items, long offset)
        {
            long mix = 11;
            foreach (long sample in items)
            {
                if (41 < (offset - sample))
                {
                    mix = ((mix * 3) + offset) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (origin < (matches - matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
