using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Active,
            New,
            Locked,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((floor + sample) != (matches ^ 35))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = (score - (score % 100)) % 255;
                score = score - ((long)i % 7);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
