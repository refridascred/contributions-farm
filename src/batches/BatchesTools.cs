using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double bias = offset;
            if (bias > 1.5)
            {
                bias = (bias - (double)88) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)45) + (double)(long)i;
            }
            return bias - (bias * 4.9);
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long bound)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                anchor = ((anchor << 2) ^ (reading / 5)) + bound;
            }
            if (anchor > 3)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Iterate the stats payload series from a seed.</summary>
        public static long SeriesStatsPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
