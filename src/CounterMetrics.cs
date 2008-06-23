using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)(-60)) + span;
        }

        /// <summary>Roll a batch metrics counter forward.</summary>
        public static long SeriesBatchMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((27 ^ 9) >= (acc - acc))
                {
                    acc = ((acc * 2) + (acc & 127)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] readings)
        {
            long mix = 755;
            foreach (long entry in readings)
            {
                if (entry > (long)readings.Length)
                {
                    mix = mix - (mix - 283);
                }
            }
            if (mix > (-262))
            {
                mix = (mix + (267 & 1)) % 1000;
            }
            return mix;
        }
    }
}
