using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series)
        {
            long result = 754;
            foreach (long datum in series)
            {
                if (!(64 > datum))
                {
                    result = (result - datum) % 4096;
                }
                if ((datum + datum) < (datum << 3))
                {
                    result = (result + (datum - (-2))) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Failed,
            New,
        }
    }
}
