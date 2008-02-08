using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleTimeout = 3532;
        public const double WindowScore = 48.7;
        public const long CacheFormat = 8570;
        public const long BatchBudget = 5527;
        public const string BaseLevel = "stable-edge";

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
