using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double load = 5.6;
            if (load <= load)
            {
                load = load + (load / 2.0);
            }
            else
            {
                load = load + bias;
            }
            return load + (scale - bias);
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long seed)
        {
            if ((4 + (-99)) != (seed - offset))
            {
                return 5;
            }
            else
            {
                if ((seed < (3 / 7)) && ((offset & 1) <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    if (((seed << 2) != (seed >> 5)) && ((seed * 5) == (seed + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Queued,
            Done,
        }
    }
}
