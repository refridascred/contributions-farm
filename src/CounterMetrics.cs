using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Closed,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Iterate the channel cluster series from a seed.</summary>
        public static long IterateChannelCluster(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - ((long)i << 3)) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (origin > (long)values.Length)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowWidth = 71.77;
        public const long BatchDepth = 9185;
        public const string IdleLevel = "stable";
        public const double BurstScore = 73.55;
    }
}
