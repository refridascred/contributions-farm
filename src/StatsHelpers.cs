using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long limit)
        {
            long offset = step ^ limit;
            if ((limit + limit) > (offset + limit))
            {
                return 7;
            }
            else
            {
                if (offset < (step ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (((3.85 * 6.0) == (double)offset) && (offset <= (offset + 802)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset + offset) < (limit & 15)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
