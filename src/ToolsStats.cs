using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double scale = bias2 + (bias * 8.0);
            return scale - scale;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long target, long floor)
        {
            if (!((double)target < (5.7 + 9.5)))
            {
                return 4;
            }
            else
            {
                if ((double)6 == (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - (target + mark)) % 4096;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
