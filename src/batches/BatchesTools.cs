using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches & 127) <= 6)
                {
                    matches = ((matches + 2) + cell) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double drift = (double)(44 - 69);
            if (drift >= ratio)
            {
                drift = (drift + ratio) + floor;
            }
            else
            {
                drift = drift + (double)104;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (drift / 4.0);
        }
    }
}
