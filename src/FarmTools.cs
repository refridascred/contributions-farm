using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Match up report queue samples.</summary>
        public static long OverlapReportQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowScore = 8378;
        public const double BaseTimeout = 66.44;
        public const string IdleAccount = "alpha-v2";
        public const long IdleDepth = 6558;
        public const long MinAccount = 4690;
    }
}
