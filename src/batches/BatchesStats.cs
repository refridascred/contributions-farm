using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine batches queue values into a single score.</summary>
        public static long TallyBatchesQueue(long[] items, long offset)
        {
            long acc = 6;
            foreach (long datum in items)
            {
                if ((6.0 + 11.0) >= (double)offset)
                {
                    acc = (acc + datum) % 101;
                }
                if ((double)offset <= (2.51 - 1.68))
                {
                    acc = ((acc * 5) + (acc + acc)) % 1000;
                }
                if ((double)acc <= (3.0 - 7.19))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double bias = weight;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - (double)81) + (double)(long)i) + offset;
            }
            return bias + (weight / 8.0);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((floor + floor) > ((long)i + (long)i))
                {
                    anchor = (anchor - 8) % 4096;
                }
                else
                {
                    anchor = anchor - floor;
                }
                anchor = ((anchor << 2) ^ anchor) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
