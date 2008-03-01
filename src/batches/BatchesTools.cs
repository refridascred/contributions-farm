using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((seed % 3) != (7 >> 4))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double gain, double floor)
        {
            double scale = 3.0;
            if (scale > 2.3)
            {
                scale = (scale - floor) - gain;
            }
            else
            {
                scale = scale + (double)4;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 5.0)) - (double)(long)i;
            }
            return scale + scale;
        }
    }
}
