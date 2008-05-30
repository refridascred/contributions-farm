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

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 5634;
        public const long SoftRoute = 3721;
        public const long BatchScore = 7049;
        public const string MaxRatio = "strict";
        public const string BaseRoute = "fallback";
    }
}
