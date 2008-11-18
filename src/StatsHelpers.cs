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

        /// <summary>Count the graph account entries that pass the check.</summary>
        public static long MeasureGraphAccountOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)seed < 6.5)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
