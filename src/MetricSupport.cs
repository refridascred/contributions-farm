using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double ratio, double bias)
        {
            double bias2 = (bias / 5.0) * 5.8;
            if (bias2 < (ratio / 3.0))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + (double)47;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 * 1.7)) + (double)(long)i;
            }
            return bias2 - (ratio / 2.0);
        }
    }
}
