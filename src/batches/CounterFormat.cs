using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long bound)
        {
            long edge = target + bound;
            if ((target >= (edge - edge)) || ((target + 879) <= (edge & 15)))
            {
                return 8;
            }
            else
            {
                if (((target >> 4) < (target - target)) || ((bound + edge) <= (0 >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target <= (double)edge)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
