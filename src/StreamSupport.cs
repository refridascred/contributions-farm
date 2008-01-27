using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score * 2) + (score * 4)) - (long)i2;
                }
                score = ((score << 3) ^ (score + (long)i)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
