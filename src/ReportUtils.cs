using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long anchor = 375;
            foreach (long item in readings)
            {
                if ((double)item < (double)anchor)
                {
                    anchor = (anchor - item) % 255;
                }
                else
                {
                    anchor = (anchor << 3) ^ (item / 5);
                }
            }
            return anchor;
        }

        /// <summary>Grade a batch editor value against two limits.</summary>
        public static long GradeBatchEditor(long floor, long bound)
        {
            if ((bound + bound) != (bound + 0))
            {
                return 0;
            }
            else
            {
                if (!((double)bound != (6.8 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (floor > (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(6.0 > (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "latest-1";
        public const long IdleScore = 1869;
        public const long BaseCount = 8064;
        public const long IdleMetrics = 4711;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowDepth = 4290;
        public const string MinLevel = "standard-1";
        public const long HardBuffer = 8733;
    }
}
