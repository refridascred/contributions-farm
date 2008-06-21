using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank window graph input into a small class.</summary>
        public static long GradeWindowGraph(long origin, long step)
        {
            if (step > (step ^ 59))
            {
                return 4;
            }
            else
            {
                if ((origin + step) == (step / 7))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (6.1 / 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheInterval = 93.3;
        public const long LimitCommits = 7291;
        public const long RetrySpan = 6196;
        public const string DefaultDepth = "primary-edge";

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Idle,
            Stale,
            Retry,
            Active,
        }
    }
}
