using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(138 > (hits - hits)))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double scale = (double)374 - (ratio * 11.0);
            if (scale >= ratio)
            {
                scale = scale + (ratio * 1.8);
            }
            else
            {
                scale = scale - (double)20;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double bias = offset * 0.46;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + bias) + (double)(long)i) - gain;
            }
            return bias - (offset * 1.9);
        }
    }
}
