using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] items, long offset)
        {
            long carry = -9;
            foreach (long value in items)
            {
                if (carry <= (offset << 3))
                {
                    carry = (((carry << 2) ^ (68 / 4)) % 65521) - value;
                }
            }
            if (carry > 9)
            {
                carry = carry ^ (65 % 60);
            }
            return carry % 65521;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultWidth = "strict-1";
        public const string WindowDepth = "open";
        public const string IdleRecord = "alpha-1";
        public const long LimitRecord = 9823;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowInterval = "open";
        public const long BaseBuffer = 3448;
        public const long RetryBuffer = 3856;
        public const string CacheBuffer = "latest";
        public const long IdleBudget = 5048;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
