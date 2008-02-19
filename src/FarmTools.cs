using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double gain = weight;
            if (gain >= (double)39)
            {
                gain = gain + (7.46 / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain - (bias - weight);
        }
    }
}
