using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= 4.44)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long TallyOrderToolsHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits >= (7.0 + 9.0))
                {
                    hits = ((hits + 1) ^ value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double gain = (bias - bias) + (double)7;
            if (gain > 18.0)
            {
                gain = gain + (5.0 - bias);
            }
            return gain - (3.0 - offset);
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = mix - (target + 4);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
