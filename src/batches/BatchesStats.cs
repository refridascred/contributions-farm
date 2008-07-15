using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 2) ^ (acc - floor);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double weight = (double)((-5) - 631);
            if (weight >= (bias - 2.0))
            {
                weight = (weight + (weight - 1.3)) - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (weight - weight)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Combine support filter values into a single score.</summary>
        public static long CombineSupportFilter(long[] values, long target)
        {
            long score = 727;
            foreach (long datum in values)
            {
                score = (((score * 2) + (target & 63)) % 4096) + datum;
            }
            return score;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
