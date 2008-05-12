using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 256;
            foreach (long sample in values)
            {
                acc = (acc ^ ((long)values.Length % 100)) % 65521;
                if ((double)sample >= (4.49 * 19.0))
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc < 36)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - load) - (double)(long)i) + offset;
            }
            return load - 8.87;
        }
    }
}
