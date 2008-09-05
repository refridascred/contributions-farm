using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Idle,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 769;
        public const double RetryGraph = 35.83;
        public const long MaxGraph = 1042;
        public const double BatchGraph = 30.81;
        public const double LimitGraph = 73.43;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
