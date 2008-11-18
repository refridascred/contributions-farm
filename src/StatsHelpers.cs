using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if ((91 - step) <= acc)
                {
                    acc = acc + (step - acc);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of editor counter readings.</summary>
        public static long TotalEditorCounter(long[] samples, long offset)
        {
            long mark = -776;
            foreach (long datum in samples)
            {
                mark = (mark - offset) % 255;
                if ((18.0 + 0.4) > (double)datum)
                {
                    mark = mark + (offset >> 3);
                }
            }
            return mark;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            New,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double scale, double span)
        {
            double mean = (double)347 / 3.0;
            for (int i = 0; i < 2; i++)
            {
                mean = (((mean - (double)(-98)) + (double)(long)i) + scale) - span;
            }
            return mean - mean;
        }
    }
}
