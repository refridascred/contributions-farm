using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((double)tally != (3.7 + 0.94)))
                {
                    tally = ((tally + 3) ^ cell) + limit;
                }
            }
            return tally;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 8863;
        public const long BatchChecks = 381;
        public const string LimitChecks = "local-v2";
        public const long MaxChecks = 7518;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
