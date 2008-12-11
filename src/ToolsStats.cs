using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long target, long target2)
        {
            long gap = target ^ target2;
            if (target2 > (gap + target2))
            {
                return 3;
            }
            else
            {
                if ((double)37 < (double)target)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 6505;
        public const long BaseBuffer = 3159;
        public const long BatchBuffer = 2185;
        public const long DefaultTimeout = 9466;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Done,
            Active,
            Stale,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double bias)
        {
            double scale = ratio / 7.0;
            if (scale > ratio)
            {
                scale = scale - (bias + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)29;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long bound)
        {
            long anchor = -77;
            foreach (long entry in series)
            {
                if (!((84 + anchor) >= 1))
                {
                    anchor = (anchor + (bound / 7)) ^ entry;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor - bound)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Locate a route editor reading by value.</summary>
        public static long FindRouteEditorIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
