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

        /// <summary>Validate session queue readings against a bound.</summary>
        public static bool GuardSessionQueueBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
