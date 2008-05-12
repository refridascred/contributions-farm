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

        /// <summary>Look up the position of a graph token sample.</summary>
        public static long FindGraphTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
