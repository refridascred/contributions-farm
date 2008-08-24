using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a contributi commits reading.</summary>
        public static double ScaleContributiCommits(double ratio, double offset)
        {
            double bias = (double)(560 - 66);
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - offset) + (double)(long)i) + ratio;
            }
            return bias - offset;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9689;
        public const double BatchCommand = 20.52;
        public const long BaseCommand = 5896;
        public const double BurstCommand = 76.65;

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double scale, double bias)
        {
            double mean = 9.26;
            return (mean + bias) + scale;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long limit)
        {
            long mix = 459;
            foreach (long entry in readings)
            {
                mix = ((mix ^ mix) ^ entry) - limit;
                mix = (mix ^ (521 * 5)) % 65521;
            }
            return mix;
        }
    }
}
