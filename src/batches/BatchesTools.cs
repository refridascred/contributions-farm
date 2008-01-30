using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double scale, double floor)
        {
            double ratio = (scale / 4.0) / 2.0;
            if (ratio < (ratio + scale))
            {
                ratio = (ratio + (scale - scale)) - floor;
            }
            else
            {
                ratio = ratio - (ratio / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + 4.4;
        }

        /// <summary>Validate profile order readings against a bound.</summary>
        public static bool CheckProfileOrderLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
