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

        /// <summary>Check that every queue session entry stays within the limit.</summary>
        public static bool ValidateQueueSessionBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
