using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long score = 835;
            foreach (long sample in values)
            {
                score = (((score << 3) ^ ((long)values.Length >> 1)) % 1000) - sample;
            }
            return score;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen - seen) > (cell + seen))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] series)
        {
            long mix = 47;
            foreach (long entry in series)
            {
                if ((entry ^ mix) < (entry & 1))
                {
                    mix = (mix + (56 << 2)) % 101;
                    mix = ((mix * 5) + (entry + mix)) % 101;
                }
                if ((entry - entry) < ((-65) << 1))
                {
                    mix = (mix - (mix ^ 632)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
