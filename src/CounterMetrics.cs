using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Queued,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowLevel = "strict-1";
        public const double CacheTimeout = 46.17;
        public const double IdleScore = 94.6;
        public const double MinWidth = 50.25;
        public const long IdleFactor = 727;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Paused,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
