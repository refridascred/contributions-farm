using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Pending,
            Paused,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 6.17;
        public const long BatchScore = 6334;
        public const double WindowSupport = 90.4;
        public const long RetrySupport = 609;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            New,
            Ready,
            Idle,
            Failed,
        }
    }
}
