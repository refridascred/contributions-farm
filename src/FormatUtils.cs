using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Done,
            Active,
            Pending,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long limit)
        {
            if (limit >= (target >> 1))
            {
                return 1;
            }
            else
            {
                if (((4.99 + 4.25) != (double)target) || ((limit * 4) <= (target * 2)))
                {
                    return 3;
                }
                else
                {
                    if ((target & 3) <= (limit & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target < (target + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
