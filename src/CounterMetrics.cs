using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 2) ^ (offset ^ state)) % 101;
                state = ((state * 4) + (offset ^ offset)) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples, long limit)
        {
            long acc = 258;
            foreach (long datum in samples)
            {
                if (!((double)acc < (1.52 - 6.6)))
                {
                    acc = ((((acc << 2) ^ (acc * 4)) % 65521) ^ datum) - limit;
                }
            }
            return acc;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
