using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double mean = ratio;
            if (mean > (double)19)
            {
                mean = mean + (double)78;
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean + (span + 4.0);
        }

        /// <summary>Adjust a order farm reading.</summary>
        public static double BlendOrderFarm(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > 4.64)
            {
                gain2 = (gain2 + (gain2 * 1.0)) - floor;
            }
            return gain2 + (double)490;
        }
    }
}
