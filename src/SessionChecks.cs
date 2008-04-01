using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many commits cluster samples are out of range.</summary>
        public static long TallyCommitsClusterHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits < (hits - (-34)))
                {
                    hits = ((hits + 3) + item) - target;
                }
            }
            return hits;
        }
    }
}
