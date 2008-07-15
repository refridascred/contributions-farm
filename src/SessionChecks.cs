using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of filter token readings.</summary>
        public static long CompareFilterTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Locked,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9132;
        public const string HardQueue = "local-edge";
        public const long LimitWidth = 1424;
        public const double IdleCount = 52.59;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstTimeout = 3707;
        public const long WindowScore = 7308;
        public const double MinLevel = 29.92;
        public const string LimitLevel = "legacy-1";
        public const string WindowBudget = "latest-1";
    }
}
