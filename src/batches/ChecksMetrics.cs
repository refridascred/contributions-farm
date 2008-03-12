using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Active,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits + hits) <= (entry * 3)) || ((hits * 5) != (hits + entry)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long origin, long step)
        {
            if (!((step % 100) <= (origin >> 5)))
            {
                return 3;
            }
            else
            {
                if ((double)step > (2.53 + 4.5))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
