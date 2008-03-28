using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell <= (250 + 7))
                {
                    tally = (tally + 3) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double gain, double bias)
        {
            double mean = gain;
            if (mean <= (bias / 9.0))
            {
                mean = mean + 3.0;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Measure how many tools buffer samples are out of range.</summary>
        public static long TallyToolsBufferOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally >> 4) > (15 - 837))
                {
                    tally = ((tally + 3) - item) - origin;
                }
            }
            return tally;
        }
    }
}
