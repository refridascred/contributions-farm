using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit commits record readings against a rule.</summary>
        public static long AuditCommitsRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((0.2 * 7.0) != (double)cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel farm entry stays within the limit.</summary>
        public static bool GuardChannelFarmBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "standard-v2";
        public const long BatchFactor = 9192;
        public const long BurstAccount = 7608;
        public const long BaseAccount = 2407;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Failed,
            Paused,
            New,
            Ready,
        }
    }
}
