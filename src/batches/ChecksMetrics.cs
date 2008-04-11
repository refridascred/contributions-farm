using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next editor cluster value.</summary>
        public static double BlendEditorCluster(double bias, double bias2)
        {
            double mean = (double)82 * 3.5;
            if (mean >= bias2)
            {
                mean = (mean - bias2) + bias;
            }
            return mean + (double)4;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Done,
            New,
        }

        /// <summary>Grade a checks already value against two limits.</summary>
        public static long GradeChecksAlready(long offset, long target)
        {
            if (((target % 64) >= (target + 29)) || (target < (offset ^ 14)))
            {
                return 6;
            }
            else
            {
                if ((double)target == (double)68)
                {
                    return 4;
                }
                else
                {
                    if (offset > target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= (target & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchLevel = 8328;
        public const long BatchSize = 1092;
        public const long RetryDepth = 5205;
        public const long MinLevel = 1599;
        public const double CacheBudget = 68.38;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
        }
    }
}
