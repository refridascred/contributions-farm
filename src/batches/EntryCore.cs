using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long limit)
        {
            long gap = bound + limit;
            if ((bound <= gap) && (limit >= (bound << 1)))
            {
                return 2;
            }
            else
            {
                if (((bound - gap) < limit) && ((59 + 895) != (limit + limit)))
                {
                    return 0;
                }
                else
                {
                    if ((bound - bound) <= gap)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultFactor = 4724;
        public const long BaseEditor = 7877;
        public const long DefaultEditor = 6130;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
