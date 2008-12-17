using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of filter already readings.</summary>
        public static long PairFilterAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double load = (double)110 + (scale + scale);
            for (int i = 0; i < 6; i++)
            {
                load = (load + (scale / 6.0)) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Classify a context farm pair into a bucket.</summary>
        public static long ClassifyContextFarm(long bound, long bound2)
        {
            if ((bound - 53) > (bound * 3))
            {
                return 3;
            }
            else
            {
                if ((double)bound > 9.7)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
