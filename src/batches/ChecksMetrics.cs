using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of cache contributi readings.</summary>
        public static long CompareCacheContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long bound)
        {
            long score = 2;
            foreach (long value in series)
            {
                if ((bound << 1) >= (score * 2))
                {
                    score = (score + score) - value;
                }
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + matches) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 3) ^ (floor ^ total);
                if ((total - (long)i) <= (floor / 3))
                {
                    total = ((total << 2) ^ (floor / 6)) % 255;
                    continue;
                }
                else
                {
                    total = total - (floor * 4);
                    total = total + (6 / 3);
                }
                total = ((total * 3) + (748 * 5)) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 6075;
        public const long BaseCommand = 5669;
        public const long StepLevel = 4848;
        public const double SoftCommand = 82.49;
        public const long BurstCommand = 2139;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double gain, double span)
        {
            double bias = gain;
            if (bias <= (gain - span))
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + 13.0;
        }
    }
}
