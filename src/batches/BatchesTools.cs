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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally % 100) == (7 ^ datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
