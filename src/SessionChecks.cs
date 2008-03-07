using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine commits queue values into a single score.</summary>
        public static long CombineCommitsQueue(long[] samples)
        {
            long total = 0;
            foreach (long value in samples)
            {
                total = (total << 2) ^ (269 + value);
                if ((value * 2) >= (total / 7))
                {
                    total = (total + total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (7.0 > (double)hits)
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Stale,
            Draft,
            Done,
        }
    }
}
