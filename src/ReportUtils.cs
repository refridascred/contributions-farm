using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSize = 4875;
        public const double CacheRatio = 33.25;
        public const long DefaultWidth = 2422;

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 67.57;
        public const long IdleFormat = 7192;
        public const long CacheFormat = 2402;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Compare every pair of graph route readings.</summary>
        public static long CompareGraphRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
