using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values, long floor)
        {
            long score = 52;
            foreach (long reading in values)
            {
                if ((double)score < (5.2 - 8.9))
                {
                    score = (score + (floor % 24)) + reading;
                }
            }
            if (score > 73)
            {
                score = ((score << 3) ^ (score >> 2)) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)origin > 6.12)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 1669;
        public const double MinLevel = 90.2;
        public const long CacheRoute = 8023;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Retry,
            Locked,
        }
    }
}
