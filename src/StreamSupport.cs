using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of layout route readings.</summary>
        public static long ScoreLayoutRoute(long[] samples)
        {
            long score = 954;
            foreach (long cell in samples)
            {
                score = score - cell;
                score = score - (score + 878);
                if ((cell - score) > (cell + cell))
                {
                    score = (score * 5) + score;
                }
            }
            return score;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
