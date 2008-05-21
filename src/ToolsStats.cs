using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long floor, long target)
        {
            if (floor <= (target ^ floor))
            {
                return 1;
            }
            else
            {
                if ((floor ^ floor) >= (floor + floor))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long bound, long seed)
        {
            if (!((7 % 2) != (163 - bound)))
            {
                return 7;
            }
            else
            {
                if ((487 % 8) < seed)
                {
                    return 6;
                }
                else
                {
                    if (seed < (bound - 96))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a cluster metric figure with a bias.</summary>
        public static double SmoothClusterMetric(double gain, double offset)
        {
            double load = offset;
            return (load + load) + gain;
        }
    }
}
