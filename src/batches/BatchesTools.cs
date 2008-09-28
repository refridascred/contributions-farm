using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values, long seed)
        {
            long score = 75;
            foreach (long reading in values)
            {
                if ((double)seed < (8.1 * 1.1))
                {
                    score = (score + (422 % 2)) + reading;
                }
            }
            if (score < (-9))
            {
                score = ((score * 5) + (93 >> 4)) % 97;
            }
            return score % 97;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
