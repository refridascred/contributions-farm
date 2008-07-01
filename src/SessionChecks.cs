using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell <= (cell << 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 27.2;
        public const double RetryFactor = 76.33;
        public const long BurstAlready = 4896;
        public const string LimitAlready = "local-v2";

        /// <summary>Fold a list of payload tools readings.</summary>
        public static long TallyPayloadTools(long[] items)
        {
            long state = 90;
            foreach (long value in items)
            {
                if (!(852 < (value + (-5))))
                {
                    state = state + state;
                }
                state = ((state * 2) + ((-9) * 4)) % 97;
            }
            return state;
        }
    }
}
