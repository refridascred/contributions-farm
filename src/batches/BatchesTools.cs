using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < bias)
            {
                scale = scale - (scale - scale);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias - bias2)) + (double)(long)i;
            }
            return scale + (4.0 * 15.0);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count < 770)
                {
                    count = ((count + 1) ^ item) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
