using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Queued,
            Active,
            New,
            Paused,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length ^ item) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSpan = 6382;
        public const double BatchSize = 68.92;
        public const double HardDepth = 79.73;
        public const double LimitBudget = 95.47;
        public const long HardScore = 6699;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank batches commits input into a small class.</summary>
        public static long GradeBatchesCommits(long limit, long target)
        {
            if ((limit + limit) >= (target + target))
            {
                return 8;
            }
            else
            {
                if ((double)target == (2.9 + 1.95))
                {
                    return 1;
                }
                else
                {
                    if ((95 + limit) != (target - target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.89 * 2.0) >= 7.7)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
