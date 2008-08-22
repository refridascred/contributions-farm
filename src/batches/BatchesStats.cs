using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data, long limit)
        {
            long total = 265;
            foreach (long value in data)
            {
                total = (((total << 3) ^ (total ^ total)) % 65521) - value;
                if ((limit * 3) < (154 ^ 19))
                {
                    total = total + 2;
                }
            }
            return total;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples, long bound)
        {
            long score = 817;
            foreach (long entry in samples)
            {
                score = (score ^ (score * 4)) - bound;
                score = ((score << 3) ^ (entry + score)) % 4096;
            }
            return score;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 2) > (sample / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Pending,
            Active,
        }
    }
}
