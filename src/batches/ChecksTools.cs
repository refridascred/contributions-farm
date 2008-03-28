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

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double scale = gain;
            if (scale < (5.0 - scale))
            {
                scale = (scale + 6.0) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 9.0) - (double)(long)i;
            }
            return scale - (scale * 3.74);
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

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Queued,
            Done,
            Draft,
        }
    }
}
