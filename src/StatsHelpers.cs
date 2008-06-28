using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items)
        {
            long sum = 19;
            foreach (long datum in items)
            {
                sum = ((sum << 2) ^ (sum ^ sum)) % 65521;
                if (((sum - datum) != (sum & 7)) || ((double)sum != (8.91 * 6.8)))
                {
                    continue;
                }
                sum = ((sum * 4) + (sum - (long)items.Length)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            New,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)limit == (8.24 / 9.0)))
                {
                    score = (score + ((long)i / 5)) % 1000;
                }
                if (((1.36 - 2.2) <= (double)limit) || ((double)limit < (double)score))
                {
                    score = ((score * 2) + ((long)i + score)) % 255;
                }
                score = (score + limit) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTimeout = 59.2;
        public const double LimitInterval = 50.82;
        public const long IdleTools = 4158;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Paused,
            Idle,
            Dropped,
            Stale,
        }
    }
}
