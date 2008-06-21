using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(((7.94 * 7.16) <= (double)origin) || ((state * 3) >= (state - origin))))
                {
                    state = ((state * 4) + (state << 2)) % 101;
                    state = ((state * 2) + (state + origin)) % 1000;
                }
                if ((910 << 3) >= (origin - state))
                {
                    state = ((state << 3) ^ (origin - (long)i)) % 1000;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
