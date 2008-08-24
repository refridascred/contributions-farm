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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix + 8)) % 4096;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if (!!(sum > (sum << 2)))
                {
                    sum = (sum - (step + step)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
