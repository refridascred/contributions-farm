using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long bound)
        {
            long delta = seed ^ bound;
            if ((bound - seed) != (529 - bound))
            {
                return 7;
            }
            else
            {
                if ((-2) >= (delta >> 4))
                {
                    return 1;
                }
                else
                {
                    if (93 > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
