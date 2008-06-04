using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the already window entries that pass the check.</summary>
        public static long CountAlreadyWindowGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry / 6) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double gain = (scale + scale) * 1.73;
            if (gain > scale)
            {
                gain = gain + (floor / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)6;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double scale, double floor)
        {
            double rate = scale / 2.0;
            if (rate < 11.0)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (double)1;
            }
            return rate + floor;
        }
    }
}
